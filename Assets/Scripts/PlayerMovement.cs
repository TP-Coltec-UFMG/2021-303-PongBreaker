using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 7.5f;
    float verticalMovement = 0f;
    Vector3 normalScale = new Vector3(0.2f, 2.5f, 1.0f);
    Vector3 enlargedScale = new Vector3(0.2f, 3.5f, 1.0f);

    private void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovement)*movementSpeed;
    }

    public void Enlarge()
    {
        gameObject.transform.localScale = enlargedScale;
        this.GetComponent<SpriteRenderer>().color = Color.yellow;
        StartCoroutine(PowerUpTimer());
    }

    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(9.5f);
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        this.gameObject.transform.localScale = normalScale;
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
