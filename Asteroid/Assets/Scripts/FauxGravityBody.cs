using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour
{
    // public varailables
    private FauxGravityAttractor fauxGravityAttractor;
    public bool placeOnSurface;

    // private varaibles
    private Rigidbody rb;

    
    void Start()
    {
        // get the only instance of attractor
        fauxGravityAttractor = FauxGravityAttractor.instance;

        // setup the rigidbody consraints
        rb = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;        
    }

    void FixedUpdate()
    {
        // place the player on surface
        if(placeOnSurface) {
            fauxGravityAttractor.PlaceOnSurface(rb);
        } else {
            fauxGravityAttractor.Attract(rb);        
        }
    }
}