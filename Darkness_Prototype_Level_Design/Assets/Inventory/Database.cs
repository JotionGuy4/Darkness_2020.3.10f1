using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public static List<Item> itemList = new List<Item>();
    public List<Item> itemsViewer;

    void Awake()
    {
        itemList.Add(new Item(0, "None", "None", Resources.Load<Sprite>("0")));
        itemList.Add(new Item(1, "Box", "It is item", Resources.Load<Sprite>("1")));
        itemList.Add(new Item(2, "Flash Light", "It is item", Resources.Load<Sprite>("2")));
        itemList.Add(new Item(3, "Scissors", "It is item", Resources.Load<Sprite>("3")));
        itemList.Add(new Item(4, "Knife", "It is item", Resources.Load<Sprite>("4")));
        itemList.Add(new Item(5, "String", "It is item", Resources.Load<Sprite>("5")));
        itemList.Add(new Item(6, "Lighter", "It is item", Resources.Load<Sprite>("6")));

        itemsViewer = itemList;
    }
}
