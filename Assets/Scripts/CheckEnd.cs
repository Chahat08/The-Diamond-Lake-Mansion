using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckEnd : MonoBehaviour
{

    // private GameObject text;
    public bool door=false;

    public float wait_time = 5f;
    public string scene = "Conclusion";

    // Start is called before the first frame update
    void Start()
    {
        // text = GameObject.Find("Text");
        // text.SetActive(false);
        //door = GameObject.Find("doorLockManager").GetComponent<managedoorLock>().openDoor;
    }

    // Update is called once per frame
    void Update()
    {
        if (door)
        {
            // text.SetActive(true);
            // Application.Quit();
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(scene);
    }
}
