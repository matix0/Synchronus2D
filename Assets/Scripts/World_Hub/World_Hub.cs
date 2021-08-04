using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_Hub : MonoBehaviour
{
    void Start()
    {
        
    }

    public float orbitspeed;
    public float rotatespeed;
    private float startingPosition;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                string novaCena = "Level_" + hitInfo.transform.name;
                SceneManager.LoadScene(novaCena);  
            }
        }

        transform.Rotate(new Vector3(0, -orbitspeed, 0));

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (startingPosition > touch.position.x)
                    {
                        var intensity = (startingPosition - touch.position.x) / 100;
                        transform.Rotate(Vector3.down, -intensity);
                    }
                    else if (startingPosition < touch.position.x)
                    {
                        var intensity = (touch.position.x - startingPosition) / 100;
                        transform.Rotate(Vector3.down, intensity);
                    }
                    break;
            }
        }
    }
}