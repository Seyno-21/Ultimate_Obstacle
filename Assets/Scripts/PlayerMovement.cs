using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public Rigidbody playerRB;
    public float jumpingForce = 5;
    public int health = 1;
    public int damage = 2;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        playerRB.velocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, playerRB.velocity.y, Input.GetAxis("Vertical") * movementSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            playerRB.velocity = new Vector3(playerRB.velocity.x, jumpingForce, playerRB.velocity.z);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (2)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (9)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (40)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (48)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (58)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (66)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (97)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (112)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (117)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (122)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
        if (col.gameObject.name == "Cube (142)")
        {
            this.transform.position = new Vector3(0f, 5.75f, 0f);
        }
    }
}
