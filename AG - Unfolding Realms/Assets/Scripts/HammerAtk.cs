using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAtk : MonoBehaviour
{
    public GameObject LtLamp;
    public GameObject Cubey;
    public AudioSource Smash;
    private bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        LtLamp = GameObject.Find("Lamp Light");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if(FindObjectOfType<UIManager>().item.gameObject.name == "hammer" && clicked == false) 
        {
            Destroy(LtLamp);
            Cubey.SetActive(true);
            FindObjectOfType<UIManager>().LightOut += 1;
        }
    }
    private IEnumerator PlayForOneSecond()
    {
        Smash.Play();
        yield return new WaitForSeconds(1f);
        Smash.Stop();
        Destroy(gameObject);

    }
}
    
