using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject OptionPanel;
    public GameObject MenuPanel;
    public GameObject Spawner;

    public void Options(GameObject OpenPanel)
    {
       
            OpenPanel.SetActive(true);
            MenuPanel.SetActive(false);
            Spawner.GetComponent<BlockSpawning>().OnMain = false;
    
    }

    public void BackButton (GameObject Panel)
    {
            Panel.SetActive(false);
            MenuPanel.SetActive(true);
            Spawner.GetComponent<BlockSpawning>().OnMain = true;
    }

    // Goes to scene Room1
    public void GoToRoom1()
    {
        SceneManager.LoadScene("Room1");
    }

    
}
