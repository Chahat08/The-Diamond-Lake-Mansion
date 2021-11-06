using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageText : MonoBehaviour
{
    public GameObject storyText, infoText;

    string[] story = { 
        "As soon as I entered, the door closed itself behind me.",
        "The dilapidated outside does not match the opulence inside...",
        "Could this have been a trap?",
        "I have to get out of here before it's too late.",
        "",
    };
    string[] info = { 
        "Click the left and right arrows to navigate",
        "Open/Close the inventory by clicking the knapsack icon on the bottom left",
        "You can also interact with some objects",
        ""
    };

    int frame = 0, sidx=0, iidx=0;
    // Start is called before the first frame update
    void Start()
    {

        // infoText.GetComponent<Text>().text = info1;

    }

    // Update is called once per frame
    void Update()
    {
        if (sidx <= 4)
            if (frame % 1000 == 0) 
                storyText.GetComponent<Text>().text = story[sidx++];


        frame += 1;
    }
}
