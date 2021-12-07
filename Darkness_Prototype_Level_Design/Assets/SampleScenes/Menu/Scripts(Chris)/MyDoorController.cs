using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    private Animator DoorAnim;
    private bool DoorOpen = false;

    private void Awake()
    {
        DoorAnim = gameObject.GetComponent<Animator>();
        checkInv = GetComponent<Inventory>();
        noKnifeText.SetActive(false);
        carriesKnifeText.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "InteractiveObject")
        {
            if (checkInv.hasknife == true)
            {
                carriesKnifeText.SetActive(true);
                DoorOpen = true;
                PlayAnimation();
            }
            else
            {
                noKnifeText.SetActive(true);
                DoorOpen = false;
            }
        }
        else
        {
            noKnifeText.SetActive(false);
            carriesKnifeText.SetActive(false);
        }
    }

        public void PlayAnimation()
    {
        if (DoorOpen == true)
        {
            DoorAnim.Play("DoorOpen", 0, 0.0f);
        }
        else
        {
            DoorAnim.Play("DoorClose", 0, 0.0f);
            DoorOpen = false;

        }
    }

}
