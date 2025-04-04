using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ItemUIScript item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inventory(ItemUIScript iScript)
    {
        if(item == null)
        {
            item = iScript;
        }
        else
        {
            //Set other item active
            item = iScript;
        }
    }
}
