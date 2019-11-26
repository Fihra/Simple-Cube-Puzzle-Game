using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 input;
    private Rigidbody rb;

    public GameObject deathParticles;

    private Vector3 spawn;

    private float maxSpeed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position;
        rb = GetComponent<Rigidbody>(); 
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

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Enemy")
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            transform.position = spawn;
        }
    }
}
