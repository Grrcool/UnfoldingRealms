using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPhysics : MonoBehaviour
{
    //use kinematic instead of gravity to add gravity to blocks.
    //iskinematic = true; etc
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {  
      rb.isKinematic = false;
      GetComponent<Rigidbody>().useGravity = true;
    }
}
