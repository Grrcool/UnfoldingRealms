using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLScript : MonoBehaviour
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
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Room2");
    }
}
