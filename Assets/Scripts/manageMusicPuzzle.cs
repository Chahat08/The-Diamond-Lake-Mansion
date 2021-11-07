using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageMusicPuzzle : MonoBehaviour
{
    public GameObject drums, piano;
    public GameObject code, diamond;
    public string clickOrder = "";
    private string correct = "dppd";

    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        code.tag = "Untagged";
        diamond.tag = "Untagged";
        //code.GetComponent<PickItem>().enabled = false;
        //code.GetComponent<pickAfterZoom>().enabled = false;
        //diamond.GetComponent<PickItem>().enabled = false;
        //diamond.GetComponent<pickAfterZoom>().enabled = false;

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(clickOrder!=correct.Substring(0, clickOrder.Length))
            clickOrder = "";

        else if(clickOrder==correct)
        {
            if (!done)
            {
                Debug.Log("music puzzle done");

                if (gameObject.GetComponent<AudioSource>() != null)
                {
                    AudioSource audio = gameObject.GetComponent<AudioSource>();
                    AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
                    audio.PlayOneShot(clip);
                }

                gameObject.GetComponent<SpriteRenderer>().enabled = true;

                code.tag = "Interactable";
                diamond.tag = "Interactable";
                //code.GetComponent<PickItem>().enabled = true;
                //code.GetComponent<pickAfterZoom>().enabled = true;
                //diamond.GetComponent<PickItem>().enabled = true;
                //diamond.GetComponent<pickAfterZoom>().enabled = true;

                gameObject.GetComponent<manageMusicPuzzle>().enabled = false;

                done = true;
            }
        }
    }
}
