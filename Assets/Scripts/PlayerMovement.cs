using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 input;
    private Rigidbody rb;

    private float maxSpeed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(input);
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (rb.velocity.magnitude < maxSpeed )
        {
            MoveCharacter(input);
        }
        
        
        //moveCharacter(input);
    }

    void MoveCharacter(Vector3 direction)
    {
        rb.AddForce(direction * moveSpeed);
    }
}
