using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela1 : MonoBehaviour
{
    public bool clicked;
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

    public void active()
    {
        GetComponent<SpriteRenderer>().sprite = spriteActive;
    }

    public void inactive()
    {
        GetComponent<SpriteRenderer>().sprite = spriteInactive;
    }
}
