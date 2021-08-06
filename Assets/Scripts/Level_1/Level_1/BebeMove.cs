using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BebeMove : MonoBehaviour
{
    public ZoomInZoomOut cameraTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;

        cameraTrigger.trigger = true;
    }
}
