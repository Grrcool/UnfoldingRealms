using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ItemUIScript item;
    public Image icon;
    public int LightOut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LightOut >= 9)
        {
            SceneManager.LoadScene("Room3");
            Debug.Log("Game Is Over");
        }
    }


    public void Inventory(ItemUIScript iScript)
    {
        if(item == null)
        {
            item = iScript;
            icon.sprite = iScript.myImaga;
        }
        else
        {
            item.Reset();
            //Hammer.SetActive(false); why is fan.setactive true?
            item = iScript;
            icon.sprite = iScript.myImaga;
        }
    }
}
