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
    }

        public void PlayAnimation()
        {
            if (!DoorOpen)
            {
                DoorAnim.Play("DoorOpen", 0, 0.0f);
                DoorOpen = true;
            }
            else
            {
                DoorAnim.Play("DoorClose", 0, 0.0f);
                DoorOpen = false;

            }
        }

}
