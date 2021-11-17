using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] Item[] yourInventory;
    [SerializeField] Item[] draggedItem;
    public int slotsNumber;

    private PickingUp pickingUp;

    public GameObject x;
    public int n;

    public int a;
    public int b; 

    public Image[] slot;
    public Sprite[] slotSprite;

    // Start is called before the first frame update
    void Start()
    {
       
         
        yourInventory = new Item[7];
        
        for (int i = 0; i < yourInventory.Length; i++)
        {
            yourInventory[i] = new Item();
            slot[i].sprite = slotSprite[i];
            slotSprite[i] = yourInventory[i].itemSprite;
        }

        yourInventory[0] = Database.itemList[0];

        pickingUp = GetComponent<PickingUp>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slotsNumber; i++)
        {
            slotSprite[i] = yourInventory[i].itemSprite;
        }
        for (int i = 0; i<slotsNumber; i++)
        {
            slot[i].sprite = slotSprite[i];
        }




        if(pickingUp.itemToPickUp != null)
        {
            x = pickingUp.itemToPickUp;
            n = x.GetComponent<ThisItem>().thisId;
        }
        else
        {
            x = null;
        }

        if(pickingUp.pick == true){
            for (int i=0; i < slotsNumber; i++)
            {
                if(yourInventory[i].id == 0 && pickingUp.pick == true)
                {
                    yourInventory[i] = Database.itemList[n];
                    pickingUp.pick = false;
                }
            }
            pickingUp.pick = false; 
        }
    }

    public void PickedUpItem(Item item)
    {
        //search through inventory and find an empty slot
        int indexOfEmpty = -1;
        for (int i = 0; i < yourInventory.Length; i++)
        {
            if (yourInventory[i].name == "")
            {
                indexOfEmpty = i;
                break;
            }
        }
        //store the item that was picked up in that empty slot
        if (indexOfEmpty == -1) return;
        else
        {
            yourInventory[indexOfEmpty] = item;
        }

        
    }
     public void DraggingItem(Image slotX)
    {
        print("Dragging:" + slotX.name);
        for(int i= 0; i<slotsNumber; i++)
        {
            if(slot[i] == slotX)
            {
                a = i; 
            }
        }
    }

    public void Drop(Image slotX)
    {
        print("Stop Dragging:" + slotX.name);
        if (a != b)
        {
            draggedItem[0] = yourInventory[0];
            yourInventory[a] = yourInventory[0];
            yourInventory[b] = draggedItem[0];
            a = 0;
            b = 0;
        }
    }

    public void Enter(Image slotX)
    {
        print("enter");
        for (int i = 0; i < slotsNumber; i++)
        {
            if(slot[i] == slotX)
            {
                a = i; 
            }
        }
    }
}
