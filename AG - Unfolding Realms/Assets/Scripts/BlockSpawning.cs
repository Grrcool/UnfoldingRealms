using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawning : MonoBehaviour
{
    public GameObject BlackCube;
    public bool OnMain = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnMain == true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(25f, 105f), 50.54f, -7.58f);
            GameObject temp = Instantiate(BlackCube, spawnPos, Quaternion.identity);
            temp.GetComponent<FallingPhysics>().Mainmenu();
        }
    }
}
