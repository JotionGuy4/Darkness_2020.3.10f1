using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private MyDoorController raycastedObj;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    [SerializeField] private Image crosshair = null;

    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    private Inventory checkInv;
    public GameObject noKnifeText;
    public GameObject carriesKnifeText;

    private void Awake()
    {
        checkInv = GetComponent<Inventory>();
        noKnifeText.SetActive(false);
        carriesKnifeText.SetActive(false);
    }

    private void NewUpdate()
    {
        // check to see if player has hit mouse button

        // if player has hit mouse button
        //  check to see if you are near the door

        //      if you are near the door
        //          ask the door what object you should check the inventory for -> hard code the knife

        //          ask the inventory if it contains the object the door wants
        //              if inventory has the object that the door wants -- open the door
    }

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                
                

                    if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<MyDoorController>();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (checkInv.hasknife == true) {
                    carriesKnifeText.SetActive(true);
                    if (Input.GetKeyDown(openDoorKey))
                    {
                        raycastedObj.PlayAnimation();
                    }
                }
                else
                {
                    noKnifeText.SetActive(true);

                }
            }

        }
        else
        {
            if(isCrosshairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool on)
    {
        if (on && !doOnce)
        {
            crosshair.tintColor = Color.red;
        }
        else
        {
            crosshair.tintColor = Color.white;
            isCrosshairActive = false;

        }
    }
}
