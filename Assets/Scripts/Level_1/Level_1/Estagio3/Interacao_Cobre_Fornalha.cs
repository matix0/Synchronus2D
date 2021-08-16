using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Cobre_Fornalha : MonoBehaviour
{
    public Animator anim;
    public ZoomInZoomOut AcompanhaCamera;
    public SpriteRenderer spriteRenderer;
    public Sprite Capacete_Quente;
    public bool Dentro = false;

    public void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        AcompanhaCamera.trigger = true;
        transform.position = objPosition;
    }
    public void OnMouseUp()
    {
        AcompanhaCamera.trigger = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
    }



    public void OnTriggerStay2D(Collider2D collision)
    {
        Dentro = true;
    }

    public void OnMouseDown()
    {
        if (Dentro == true)
        {
            spriteRenderer.sprite = Capacete_Quente;
        }
    }
}
