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

    //public GameObject todo;
    //private bool c1, c2;

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

            /*if(c1 && !c2)
            {
                // enable check 2, check 1 enabled already
                todo.GetComponent<todoManager>().chk2 = true;
            }
            else if(c2 && !c1)
            {
                // enable check 1, check 2 enabled already
                todo.GetComponent<todoManager>().chk1 = true;

                GameObject.Find("check1").SetActive(true);
                GameObject.Find("todo").GetComponent<ChangeView>().SpriteName = "todo1";
            }
            if(GameObject.Find("check2") != null && GameObject.Find("check1") != null)
            {
                GameObject.Find("todo").GetComponent<ChangeView>().SpriteName = "todo12";
            }*/
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
        diamond_lock = GameObject.Find(lock_name);
        diamond_lock.SetActive(false);

        /*c1 = todo.GetComponent<todoManager>().chk1;
        c2 = todo.GetComponent<todoManager>().chk2;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

