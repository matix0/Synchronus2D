using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_Hub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float orbitspeed;
    public float rotatespeed;
    private float startingPosition;

    void Update()
    {
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

        transform.Rotate(new Vector3(0, orbitspeed, 0));

        if (Input.touchCount > 0)
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
                        transform.Rotate(Vector3.down, -rotatespeed);
                    }
                    else if (startingPosition < touch.position.x)
                    {
                        transform.Rotate(Vector3.down, rotatespeed);
                    }
                    break;
            }
        }
    }

    private string SomarStrings(string a, string b)
    {
        int v1 = int.Parse(a);
        int v2 = int.Parse(b);

        int v3 = v1 + v2;

        string resultado = v3.ToString();

        return resultado;
    }
}