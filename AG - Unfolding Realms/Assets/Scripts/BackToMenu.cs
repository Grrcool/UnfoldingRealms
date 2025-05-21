using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator NextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            yield return new WaitForSeconds(10);
            SceneManager.LoadScene("Menu");
        }
    }
}
