using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class FadingLight : MonoBehaviour
{
    public ParticleSystem BrightLight;

    // Start is called before the first frame update
    void Start()
    {
        BrightLight.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
