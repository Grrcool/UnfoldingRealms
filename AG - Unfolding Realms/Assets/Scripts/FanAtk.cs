using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAtk : MonoBehaviour
{
    public AudioSource wind;
    private bool clicked = false;

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
        if (FindObjectOfType<UIManager>().item.gameObject.name == "Metro Fan" && clicked == false)
        { 
            clicked = true;
            FindObjectOfType<UIManager>().LightOut += 1;
            StartCoroutine(PlayForOneSecond());
        }
    }
    private IEnumerator PlayForOneSecond()
    {
        wind.Play();
        yield return new WaitForSeconds(1f);
        wind.Stop();
        Destroy(gameObject);

    }
}
