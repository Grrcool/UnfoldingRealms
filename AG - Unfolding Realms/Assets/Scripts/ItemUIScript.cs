using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIScript : MonoBehaviour
{
    UIManager UIManager;
    public Sprite myImaga;

    // Start is called before the first frame update
    void Start()
    {
       UIManager = FindObjectOfType<UIManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        //holdItem = this; (needs UIManager Done)
    }
}
