using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managedoorLock : MonoBehaviour
{
    public bool openDoor = false;

    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(openDoor)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            openDoor = false;
            gameObject.SetActive(false);
        }
    }
}
