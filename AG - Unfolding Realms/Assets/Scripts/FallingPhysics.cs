using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPhysics : MonoBehaviour
{
    //use kinematic instead of gravity to add gravity to blocks.
    //iskinematic = true; etc
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        rb.useGravity=true;
    }
}
