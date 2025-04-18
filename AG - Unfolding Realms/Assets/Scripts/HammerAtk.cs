using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAtk : MonoBehaviour
{
    public GameObject LtLamp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if(FindObjectOfType<UIManager>().item.gameObject.name == "hammer") 
        { 
        Destroy(this);
            Debug.Log("NONOWORk");
        }
    }
}
    
