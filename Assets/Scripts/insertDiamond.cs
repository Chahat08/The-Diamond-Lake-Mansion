using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class insertDiamond : MonoBehaviour, IInteractable
{

    public string UnlockItem;
    public string lock_name;
    public bool unlocked = false;

    private GameObject inventory;

    private GameObject diamond_lock;

    private todoManager todo;
    private bool c1, c2;

    public void Interact(DisplayImage currentDisplay)
    {
        // if the current selected slot has an item whose name is the same as UnlockItem, then
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("unlock");
            diamond_lock.SetActive(true);
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Items/empty");
            unlocked = true;

            if(!c1 && !c2)
            {
                todo.chk1 = true;
                todo.stringName = "todo1";
            }

            //else if(c1 && !c2)
            else
            {
                // enable check 2, check 1 enabled already
                todo.chk2 = true;
                todo.stringName = "todo12";
            }
            /*else if(c2 && !c1)
            {
                // enable check 1, check 2 enabled already
                todo.chk1 = true;
                todo.stringName = "todo1";

                //GameObject.Find("check1").SetActive(true);
                //GameObject.Find("todo").GetComponent<ChangeView>().SpriteName = "todo1";
            }
            if (GameObject.Find("check2") != null && GameObject.Find("check1") != null)
            {
                //GameObject.Find("todo").GetComponent<ChangeView>().SpriteName = "todo12";
            }*/
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
        diamond_lock = GameObject.Find(lock_name);
        diamond_lock.SetActive(false);

        todo = GameObject.Find("sceneManager").GetComponent<todoManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

