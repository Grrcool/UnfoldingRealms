using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockSpawning : MonoBehaviour
{
    public GameObject BlackCube;
    public bool OnMain = true;
    public Rigidbody rb;
    private Rigidbody Cube;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cube = BlackCube.GetComponent<Rigidbody>();
        StartCoroutine(NextScene());
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
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Vector3 spawnPos = new Vector3(Random.Range(122.7f, 340f), 199.9f, -18.6f);
            GameObject temp = Instantiate(BlackCube, spawnPos, Quaternion.identity);
            Cube.isKinematic = false;
            Cube.useGravity = true;
        }
    }
    IEnumerator NextScene()
    {
        if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            yield return new WaitForSeconds(5.0f);
            SceneManager.LoadScene("Menu");
        }
    }
}
