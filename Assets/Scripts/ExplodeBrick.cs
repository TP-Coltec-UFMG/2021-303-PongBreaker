using System.Collections;
using UnityEngine;

public class ExplodeBrick : MonoBehaviour
{
    public int health;
    public int explosionDamage;
    public float explosionRadius;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Brick"))
        {
            col.gameObject.GetComponent<BreakBrick>().health = -explosionDamage;
            if (col.gameObject.GetComponent<BreakBrick>().health <= 0)
            {
                col.gameObject.GetComponent<BreakBrick>().StartCoroutine("Break");
                FindObjectOfType<Score>().score += 250f;
            }
        }
        if (col.gameObject.CompareTag("MetalBrick"))
        {
            col.gameObject.GetComponent<BreakBrick>().health = -explosionDamage;
            if (col.gameObject.GetComponent<BreakBrick>().health <= 0)
            {
                col.gameObject.GetComponent<BreakBrick>().StartCoroutine("Break");
                FindObjectOfType<Score>().score += 150f;
            }
        }
        if (col.gameObject.CompareTag("ExplosiveBrick"))
        {
            col.gameObject.GetComponent<ExplodeBrick>().health = -explosionDamage;
            if (col.gameObject.GetComponent<ExplodeBrick>().health <= 0)
            {
                col.gameObject.GetComponent<ExplodeBrick>().StartCoroutine("Break");
                FindObjectOfType<Score>().score += 550f;
            }
        }
    }

        public IEnumerator Break()
    {
        GetComponent<CircleCollider2D>().radius = explosionRadius;
        GetComponentInChildren<ParticleSystem>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(GetComponentInChildren<ParticleSystem>().main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
