using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour
{
    public ZoomInZoomOut cameraTrigger;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            cameraTrigger.trigger = false;
        }
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;

        cameraTrigger.trigger = true;

        if (gameObject.GetComponent<Rigidbody2D>() == null)
        {
            Destroy(GetComponent<BoxCollider2D>());

            Rigidbody2D gameObjectsRigidBody = gameObject.AddComponent<Rigidbody2D>();
            GetComponent<Rigidbody2D>().mass = 5;
        }
    }
}
