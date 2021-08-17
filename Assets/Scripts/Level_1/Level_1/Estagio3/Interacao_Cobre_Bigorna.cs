using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Cobre_Bigorna : MonoBehaviour
{
    //public Animator anim;
    public ZoomInZoomOut AcompanhaCamera;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D colisor;
    public Interacao_Fole Fole;
    public Sprite Capacete_Quente;
    public Sprite Capacete_Frio;
    public bool Bigorna = false;
    public bool Balde = false;
    public int Martelou = 0;

    private void Start()
    {
        colisor.enabled = false;
    }
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

    /*public void OnTriggerEnter2D(Collider2D collision)
    {
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bigorna"))
        {
            Bigorna = true;


        }
        if (collision.gameObject.CompareTag("Balde"))
        {
            if (Martelou > 2)
            {
                spriteRenderer.sprite = Capacete_Frio;
            }

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bigorna"))
        {
            Bigorna = false;


        }
        if (collision.gameObject.CompareTag("Balde"))
        {
            Balde = false;

        }
    }
    public void OnMouseDown()
    {
        if (Fole.ApertouFole == true)
        {
            if (Bigorna == true)
            {
                if (spriteRenderer.sprite != Capacete_Frio)
                {
                    spriteRenderer.sprite = Capacete_Quente;
                    Martelou += 1;
                }

            }


        }
    }
}
