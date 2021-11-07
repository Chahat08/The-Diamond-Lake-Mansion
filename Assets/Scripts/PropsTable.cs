using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class PropsTable : MonoBehaviour, IInteractable
{
    public string UnlockItem;

    private GameObject inventory;

    private GameObject propsTable;
    private GameObject check;

    private GameObject todo;
    private GameObject check1;
    private bool isOtherCheckActive;

    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openIt(string url)
    {
#if UNITY_EDITOR || UNITY_WEBGL
             OpenNewTab(url);
#endif
        Debug.Log("inside the fn");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        // if the current selected slot has an item whose name is the same as UnlockItem, then
        /*if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("unlock");
            propsTable.SetActive(true);
            check.SetActive(true);

            if (todo.GetComponent<ChangeView>().SpriteName == "todo")
            {
                if (isOtherCheckActive)
                {
                    todo.GetComponent<ChangeView>().SpriteName = "todo12";
                }
                else todo.GetComponent<ChangeView>().SpriteName = "todo2";
            }

            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Items/empty");
        }*/
        //Application.ExternalEval("window.open(\"http://www.unity3d.com\")");
        openIt("www.google.com");
        Debug.Log("checking open");

    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
        propsTable = GameObject.Find("propsTable");
        check = GameObject.Find("check2");
        todo = GameObject.Find("todoList");
        check1 = GameObject.Find("check1");

        if (check1 != null) isOtherCheckActive = true;
        else isOtherCheckActive = false;

        check.SetActive(false);
        propsTable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}