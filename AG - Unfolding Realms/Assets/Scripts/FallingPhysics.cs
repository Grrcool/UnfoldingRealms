using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingPhysics : MonoBehaviour
{
    //use kinematic instead of gravity to add gravity to blocks.
    //iskinematic = true; etc
    public Rigidbody rb;
    public bool mainMenu = false;
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
        if (mainMenu == false)
        {
            rb.isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            GameObject.FindObjectOfType<NextLevel>().droppedCubes += 1;
        }
      
    }

    public void GravityActive()
    {
        rb.isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void Mainmenu ()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
        mainMenu = true;
        StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4.5f);
        Destroy(gameObject);
    }
}
