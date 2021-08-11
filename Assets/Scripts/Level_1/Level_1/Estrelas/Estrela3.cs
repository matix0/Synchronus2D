using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela3 : MonoBehaviour
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
        GetComponent<SpriteRenderer>().sprite = spriteActive;
    }

    public void inactive()
    {
        GetComponent<SpriteRenderer>().sprite = spriteInactive;
    }
}
