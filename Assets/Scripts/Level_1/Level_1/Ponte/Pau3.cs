using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pau3 : MonoBehaviour
{
    private Animator anim;
    public Ponte parent;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("tocado");
    }

    private void callParent()
    {
        parent.stage += 1;
        parent.updatePonte();
    }
}
