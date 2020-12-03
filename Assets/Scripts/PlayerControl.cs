using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody rbPlayer;
    public Animator anPlayer;
    Vector3 velocity;
    public float speed = 0.7f;


    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = this.GetComponent<Rigidbody>();
        anPlayer = this.GetComponent<Animator>();

    }
    private void FixedUpdate()  
    {
        Run();
        Jump();
    }

    void Run()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * speed * Time.deltaTime;
        anPlayer.SetFloat("isTurn", Input.GetAxis("Horizontal"));
        transform.Translate(velocity);

        anPlayer.SetFloat("playerSpeed", velocity.z);
       
    }
    void Jump()
    {
        if (Input.GetKey("r"))
        {
            anPlayer.SetFloat("isJumping", 1);
        }
        else { anPlayer.SetFloat("isJumping", 0); }
    }
}
