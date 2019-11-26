using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 input;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(input);
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //moveCharacter(input);
    }

    void FixedUpdate()
    {
        MoveCharacter(input);
    }

    void MoveCharacter(Vector3 direction)
    {
        rb.AddForce(direction * moveSpeed * Time.deltaTime);
    }
}
