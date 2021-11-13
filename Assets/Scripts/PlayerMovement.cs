using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 7.5f;
    float verticalMovement = 0f;
    
    private void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovement)*movementSpeed;
    }
}
