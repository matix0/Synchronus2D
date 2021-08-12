using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Cobre_Bigorna : MonoBehaviour
{
    private Animator anim;
    public Interacao_Cobre_Fornalha Cobre_Fornalha;
    public ZoomInZoomOut AcompanhaCamera;
    public Sprite capacete;
    public SpriteRenderer spriteRenderer;

    private void Update()
    {
        /*void OnTriggerEnter2D(Collider2D collider2D)
        {
            if(Cobre_Fornalha.gameObject. = true)
            {
                Destroy(Cobre_Fornalha.gameObject, 1);
            }

            anim.SetTrigger("Entrou");
        }*/
    }

    void OnMouseDrag()
    {
        spriteRenderer.sprite = capacete;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        AcompanhaCamera.trigger = true;
        transform.position = objPosition;
    }
    void OnMouseUp()
    {

        AcompanhaCamera.trigger = false;
    }

}
