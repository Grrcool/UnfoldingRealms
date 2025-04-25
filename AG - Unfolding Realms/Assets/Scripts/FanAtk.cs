using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAtk : MonoBehaviour
{
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
        if (FindObjectOfType<UIManager>().item.gameObject.name == "Metro Fan")
        {
            FindObjectOfType<UIManager>().LightOut += 1;
            Destroy(gameObject);
        }
    }
}
