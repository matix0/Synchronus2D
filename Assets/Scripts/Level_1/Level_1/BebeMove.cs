using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BebeMove : MonoBehaviour
{
  

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


        if (gameObject.GetComponent<Rigidbody2D>() == null)
        {
            Rigidbody2D gameObjectsRigidBody = gameObject.AddComponent<Rigidbody2D>();
            GetComponent<Rigidbody2D>().mass = 100;
        }
    }



}
