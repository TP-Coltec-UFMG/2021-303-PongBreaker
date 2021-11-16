using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float speed = 15;
    public Animator animator;

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

        if (col.gameObject.name == "Player")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "ParedeDir")
        {
            animator.SetBool("IsDead", true);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (col.gameObject.CompareTag("Brick"))
        {
            FindObjectOfType<Score>().score += 50f;
            col.gameObject.GetComponent<BreakBrick>().health--;
            if (col.gameObject.GetComponent<BreakBrick>().health == 0)
            {
                col.gameObject.SetActive(false);
                FindObjectOfType<Score>().score += 200f;
            }
            if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
            {
                FindObjectOfType<GameManager>().CompleteLevel();
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Rigidbody2D>().angularVelocity = 0f;
            }
        }
    }
}
