﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverTijolo : MonoBehaviour
{
    private Animator anim;
    public bool AchouTijolo;
    public BoxCollider2D BoxEspada;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        anim.SetTrigger("Clicou");
        AchouTijolo = true;
        BoxEspada.enabled = true;
    }
}
