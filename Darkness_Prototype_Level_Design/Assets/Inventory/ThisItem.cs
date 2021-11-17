using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisItem : MonoBehaviour
{
    public Item thisItem;
    public int thisId;
    [Header("Fields below are populated by 'thisID'")]
    public int id;
    public string itemName;
    public string itemDescription;

    // Start is called before the first frame update
    void Start()
    {
        thisItem = Database.itemList[thisId];
        id = thisItem.id;
        itemName = thisItem.name;
        itemDescription = thisItem.description;
    }

    // Update is called once per frame
    void Update()
    {
        id = thisItem.id;
        itemName = thisItem.name;
        itemDescription = thisItem.description;
    }
}
