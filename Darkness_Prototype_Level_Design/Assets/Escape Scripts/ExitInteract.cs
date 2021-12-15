using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInteract : MonoBehaviour
{
    public GameObject noKnifeText;
    public GameObject carriesKnifeText;
    public GameObject exit;
    public bool canExit = false;
    public bool cannotExit = false;
    private Inventory checkInventory;

    // Start is called before the first frame update
    void Start()
    {
        checkInventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

        if (canExit == true)
        {
            carriesKnifeText.SetActive(true);

        }
        else if (cannotExit == true)
        {
            noKnifeText.SetActive(true);
        }
        else
        {
            noKnifeText.SetActive(false);
            carriesKnifeText.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (checkInventory.hasknife == true)
        {
            if (col.tag == "InteractiveObject")
            {
                canExit = true;
                cannotExit = false;
            }
        }
        else
        {
            canExit = false;
            cannotExit = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "InteractiveObject")
        {
            canExit = false;
            cannotExit = false;
        }
    }
}
