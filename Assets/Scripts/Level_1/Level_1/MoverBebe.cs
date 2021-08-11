using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBebe : MonoBehaviour
{
    public ZoomInZoomOut AcompanhaCamera;
    [HideInInspector]
    public RemoverEsconderijo RemoverEsconderijo;
    [HideInInspector]
    public RemoverEsconderijo2 RemoverEsconderijo2;
    [HideInInspector]
    public RemoverEsconderijo3 RemoverEsconderijo3;
    public Sprite bebeAchado;
    public SpriteRenderer spriteRenderer;

    void OnMouseDrag()
    {
        if (RemoverEsconderijo.AchouEsconderijo == true || RemoverEsconderijo2.AchouEsconderijo2 == true || RemoverEsconderijo3.AchouEsconderijo3 == true)
        {
            spriteRenderer.sprite = bebeAchado;
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
