using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rd;

    public float forwardforce = -420f;
    public float sidewaysForce = 300f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rd.AddForce(forwardforce * Time.deltaTime, 0, 0);

        if( Input.GetKey("d")) {
            rd.AddForce(0,0, sidewaysForce * Time.deltaTime);
        }
        if( Input.GetKey("a")) {
            rd.AddForce(0,0, -sidewaysForce * Time.deltaTime);
        }
        
    }
}
