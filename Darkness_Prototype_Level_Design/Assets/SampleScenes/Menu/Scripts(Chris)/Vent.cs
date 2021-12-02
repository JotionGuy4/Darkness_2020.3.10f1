using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour
{
    private Animator VentAnim;

    private bool VentOpen = false;

    private void Awake()
    {
        VentAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!VentOpen)
        {
            VentAnim.Play("VentAnimation", 0, 0.0f);
            VentOpen = true;
        }
    }

}
