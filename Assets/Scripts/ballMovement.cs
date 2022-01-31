using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float speed = 15;
    public Animator animator;
    public bool forceShield;

    public AudioSource brickHit;
    public AudioSource metalHit;
    public AudioSource dedAudio;
    public AudioSource dedShieldAudio;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    float hitFactor(Vector2 bolaPos, Vector2 jogPos, float tam)
    {
        return (bolaPos.y - jogPos.y) / tam;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag.ToString())
        {
            case "MetalBrick":

                metalHit.Play();
                break;

            case "Player":

                brickHit.Play();
                float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
                Vector2 dir = new Vector2(-1, y).normalized;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
                break;

            case "Goal":

                if (forceShield == true)
                {
                    forceShield = false;
                    dedShieldAudio.Play();
                    GetComponent<SpriteRenderer>().color = Color.white;
                    GetComponent<TrailRenderer>().startColor = Color.white;
                }
                else
                {
                    animator.SetBool("IsDead", true);
                    dedAudio.Play();
                    GetComponent<SpriteRenderer>().enabled = false;
                    GetComponentInChildren<ParticleSystem>().Play();
                    GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    GetComponent<Rigidbody2D>().angularVelocity = 0f;
                    FindObjectOfType<GameManager>().EndGame();
                }
                break;

            case "Brick":

                brickHit.Play();
                FindObjectOfType<Score>().score += 50f;
                col.gameObject.GetComponent<BreakBrick>().health--;
                if (col.gameObject.GetComponent<BreakBrick>().health == 0)
                {
                    col.gameObject.GetComponent<BreakBrick>().StartCoroutine("Break");
                    FindObjectOfType<Score>().score += 200f;
                }
                break;

            case "ExplosiveBrick":

                FindObjectOfType<Score>().score += 50f;
                col.gameObject.GetComponent<ExplodeBrick>().health--;
                if (col.gameObject.GetComponent<ExplodeBrick>().health == 0)
                {
                    col.gameObject.GetComponent<ExplodeBrick>().StartCoroutine("Break");
                    FindObjectOfType<Score>().score += 500f;
                }
                break;

            case "ShieldBrick":

                FindObjectOfType<Score>().score += 50f;
                col.gameObject.GetComponent<BreakBrick>().health--;
                if (col.gameObject.GetComponent<BreakBrick>().health == 0)
                {
                    col.gameObject.GetComponent<BreakBrick>().StartCoroutine("Break");
                    FindObjectOfType<Score>().score += 250f;
                    forceShield = true;
                    GetComponent<SpriteRenderer>().color = Color.green;
                    GetComponent<TrailRenderer>().startColor = Color.green;
                }
                break;

            case "YellowBrick":

                FindObjectOfType<Score>().score += 50f;
                col.gameObject.GetComponent<BreakBrick>().health--;
                if (col.gameObject.GetComponent<BreakBrick>().health == 0)
                {
                    col.gameObject.GetComponent<BreakBrick>().StartCoroutine("Break");
                    FindObjectOfType<PlayerMovement>().Invoke("Enlarge", 0f);
                }
                break;

            default:
                brickHit.Play();
                break;
        }
    }
}
