﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela4 : MonoBehaviour
{
    public bool clicked, entered;
    public Vector3 vertex;
    public Sprite spriteActive, spriteInactive;

    private void Awake()
    {
        vertex = transform.position;
    }

    private void OnMouseDown()
    {
        clicked = true;
    }

    private void OnMouseEnter()
    {
        entered = true;
    }
    private void OnMouseExit()
    {
        entered = false;
    }
    public void active()
    {
        GetComponent<Animator>().SetTrigger("activate");
        GetComponent<Animator>().ResetTrigger("deactivate");
    }

    public void inactive()
    {
        GetComponent<Animator>().SetTrigger("deactivate");
        GetComponent<Animator>().ResetTrigger("activate");
    }
}
