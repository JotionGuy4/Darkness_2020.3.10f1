using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitItemController : MonoBehaviour
{
    [SerializeField] public bool open = false;
    [SerializeField] public bool knife = false;
    public float exitOpenAngle = 90f;
    public float closeAngle = 0f;
    public float smooth = 2f;

    public ExitKnifeController exitObject;
    private Inventory exitInventory;

    void Start()
    {
        exitInventory = GetComponent<Inventory>();
    }

    public void ObjectInteraction()
    {
        if (exitInventory.hasknife == true)
        {
            gameObject.SetActive(false);
        }
    }
}

