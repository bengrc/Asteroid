using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public variables
    [Range(0,15)]
    public float moveSpeed;

    [Range(50, 250)]
    public float rototionSpeed;

    [HideInInspector]
    public bool isDead;

    //public float moveSpeed = 1;
    private Vector3 moveDirection;
    

    // private variables
    private Rigidbody rb;
    private float rotation;
    private float score;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // initailize the private varaibles
        rb = this.GetComponent<Rigidbody>();
        isDead = false;
    }

    void Update()
    {
        // gets the rotation value from input axis
        rotation = Input.GetAxisRaw("Horizontal");
         moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;    
        /* if(scoreText == null)
            return;
        if(!isDead) {
            score = score + Time.deltaTime;
        } */
    }

    void FixedUpdate()
    {
        // moves the player in its front direction
        rb.MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * 20 * Time.deltaTime);
        
       /*  rb.MovePosition(rb.position + this.transform.forward * -moveSpeed * Time.fixedDeltaTime);

        // rotates the car with input
        Vector3 rotationY = Vector3.up * rotation * rototionSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(rotationY);
        Quaternion targetRotation = rb.rotation * deltaRotation;
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.fixedDeltaTime));     */
    }
}
