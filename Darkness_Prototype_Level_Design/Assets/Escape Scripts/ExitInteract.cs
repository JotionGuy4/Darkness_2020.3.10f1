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
    public Inventory checkInventory;

    // Start is called before the first frame update
    void Start()
    {

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
            
            carriesKnifeText.SetActive(false);
        }
        if (cannotExit == true)
        {
            noKnifeText.SetActive(true);

        }
        else
        {
            noKnifeText.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger has entered and is called " + col.gameObject.name);
        if (col.tag == "Player")
        {
            Debug.Log("The colliders tag is InteractiveObject");
            if (checkInventory.hasknife == true)
            {
                Debug.Log("We have a knife.");
                canExit = true;
                cannotExit = false;
            }
            else
            {
                canExit = false;
                cannotExit = true;
            }
        }
        else Debug.Log("The colliders tag is " + col.gameObject.tag);
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
