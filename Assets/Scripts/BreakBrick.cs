using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            health--;
        }

        if (health <= 0)
        {
            Debug.Log("Hit");
            this.enabled = false;
        }
    }
}
