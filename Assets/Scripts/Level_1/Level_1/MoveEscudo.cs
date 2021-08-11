using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveEscudo : MonoBehaviour
{
    public RemoverMatinho RemoverMatinho;
    public ZoomInZoomOut AcompanhaCamera;
    public Sprite escudoAchado;
    public SpriteRenderer spriteRenderer;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            AcompanhaCamera.trigger = false;
        }

        if (RemoverMatinho.AchouMatinho == true)
        {
            GetComponent<CircleCollider2D>().enabled = true;
            GetComponent<CircleCollider2D>().radius = 3;
        }    
    }

    void OnMouseDrag()
    {
        if (RemoverMatinho.AchouMatinho == true)
        {
            transform.localScale = new Vector3(0.2f,0.2f,1);
            spriteRenderer.sprite = escudoAchado;
            spriteRenderer.sortingOrder = 10;
        }

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        AcompanhaCamera.trigger = true;

        transform.position = objPosition;
    }
}
