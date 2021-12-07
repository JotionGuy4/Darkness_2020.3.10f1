using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInteract : MonoBehaviour
{
    public GameObject noKnifeText;
    public GameObject carriesKnifeText;
    public GameObject exit;
    public bool canExit;
    private Inventory checkInventory;

    // Start is called before the first frame update
    void Start()
    {
        checkInventory = GetComponent<Inventory>();
        canExit = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (canExit == true)
        {
            carriesKnifeText.SetActive(true);

        }
        else
        {
            noKnifeText.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (checkInventory.hasknife == true)
        {
            if (col.tag == "InteractiveObject")
            {
                canExit = true;
            }
        }
        else
        {
            canExit = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "InteractiveObject")
        {
            canExit = false;

        }
    }
}  
