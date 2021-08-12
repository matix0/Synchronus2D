using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Cobre_Fornalha : MonoBehaviour
{
    public ZoomInZoomOut AcompanhaCamera;

    void OnMouseDrag()
    {
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
