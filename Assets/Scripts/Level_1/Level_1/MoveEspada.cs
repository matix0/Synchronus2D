using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEspada : MonoBehaviour {
    public ZoomInZoomOut AcompanhaCamera;
    public RemoverTijolo RemoverTijolo;
    public Sprite espadaAchada;
    public SpriteRenderer spriteRenderer;

    void OnMouseDrag()
    {
        if (RemoverTijolo.AchouTijolo == true)
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 1);
            transform.localRotation = new Quaternion(0, 0, 0.943f, 0.334f);
            spriteRenderer.sprite = espadaAchada;
            RemoverTijolo.AchouTijolo = false;
        }

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