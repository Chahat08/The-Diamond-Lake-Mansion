using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class todoSpriteDisplay : MonoBehaviour
{
    //private GameObject scM;
    private todoManager td;
    public GameObject c1, c2;
    private bool d1=false, d2=false;

    // Start is called before the first frame update
    void Start()
    {
        td = GameObject.Find("sceneManager").GetComponent<todoManager>();
        c1.GetComponent<SpriteRenderer>().enabled = false;
        c2.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<ChangeView>().SpriteName = td.stringName;
        if (!d1 && td.chk1) { c1.GetComponent<SpriteRenderer>().enabled = true; d1 = true; }
        if (!d2 && td.chk2) { c2.GetComponent<SpriteRenderer>().enabled = true; d2 = true; }
    }
}
