using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int droppedCubes; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(droppedCubes > 10)
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                Debug.Log("S");
                foreach (var item in FindObjectsOfType<FallingPhysics>())
                {
                    item.GravityActive();
                }
                
            }
            else
            {
                SceneManager.LoadScene("FadingEffect");
            }
            
        }
    }
}
