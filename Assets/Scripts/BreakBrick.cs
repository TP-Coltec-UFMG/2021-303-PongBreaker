using System.Collections;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    public int health;

    public IEnumerator Break()
    {
        GetComponentInChildren<ParticleSystem>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(GetComponentInChildren<ParticleSystem>().main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
