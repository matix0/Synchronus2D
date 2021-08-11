using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvem1 : MonoBehaviour
{

    void Update()
    {

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
}
