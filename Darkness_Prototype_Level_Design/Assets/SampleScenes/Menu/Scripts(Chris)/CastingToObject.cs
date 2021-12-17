using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour
{
    public string selectedObject;
    public RaycastHit theObject;
    public LayerMask ilm;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out theObject, 30, ilm, QueryTriggerInteraction.Collide))
        {
            selectedObject = theObject.transform.gameObject.name;
        }

    }
}
