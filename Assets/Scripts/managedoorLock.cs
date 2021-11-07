using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managedoorLock : MonoBehaviour
{
    //public bool openDoor = false;
    public GameObject d1, d2, mainDiamond;
    private bool done = false;
    //public GameObject mainDiamond;

    public float wait_time = 5f;
    public string scene = "Conclusion";

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
        mainDiamond.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(d1.GetComponent<insertDiamond>().unlocked && d2.GetComponent<insertDiamond>().unlocked && !done)
        {
            mainDiamond.SetActive(true);
            done = true;
        }
        if(done)
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(scene);
    }
}