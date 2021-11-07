using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class introSceneManager : MonoBehaviour
{
    //public GameObject img;
    public GameObject txt;

    public float wait_time = 2f;
    public string scene = "SampleScene";

    string[] story = {
        "For a top-class spy like you, no case has even been too hard.",
        "And yet...",
        "The diamond theif Crystal Filcher keeps on giving you the slip.",
        "Finally, you make a breakthrough which leads you to The Diamond Lake Shed.",
        "You go there...",
    };
    int frame = 0, sidx = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sidx <= 4)
        {
            if (frame % 950 == 0)
            {
                //storyText.SetActive(true);
                txt.GetComponent<Text>().text = story[sidx++];
                //storyText.SetActive(false);
            }
            //if (sidx == 4) txt.SetActive(false);
        }

        frame += 1;
        if(sidx==5)
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
