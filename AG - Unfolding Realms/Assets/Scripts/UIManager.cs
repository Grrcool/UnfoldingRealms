using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ItemUIScript item;
    public GameObject fan;
    // Start is called before the first frame update
    void Start()
    {
        fan = GameObject.Find("Metro Fan");
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
            fan.SetActive(true);
            item = iScript;
        }
    }
}
