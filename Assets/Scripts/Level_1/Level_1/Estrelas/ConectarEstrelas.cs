using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectarEstrelas : MonoBehaviour
{
    public Estrela1 estrela1;
    public Estrela2 estrela2;
    public Estrela3 estrela3;
    public Estrela4 estrela4;

    public GameObject complete1, complete2, complete3;

    private int stage = -1;
    private LineRenderer line;
    private Vector3 currentVertex, mousePos;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        currentVertex = estrela1.vertex;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (stage == -1 && estrela2.clicked)
            {
                estrela2.inactive();
                stage++;
            }

            if (stage == 0 && estrela1.clicked)
            {
                estrela1.inactive();
                estrela2.active();

                currentVertex = estrela1.vertex;

                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                line.SetPosition(1, new Vector3(mousePos.x, mousePos.y, transform.position.z));

                if (estrela2.entered)
                {
                    currentVertex = estrela2.vertex;
                    line.SetPosition(0, currentVertex);
                    line.SetPosition(1, currentVertex);
                    complete1.GetComponent<SpriteRenderer>().enabled = true;
                    stage++;
                }
            }

            if (stage == 1 && estrela2.clicked)
            {
                estrela2.inactive();
                estrela3.active();

                currentVertex = estrela2.vertex;

                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                line.SetPosition(1, new Vector3(mousePos.x, mousePos.y, transform.position.z));

                if (estrela3.entered)
                {
                    currentVertex = estrela3.vertex;
                    line.SetPosition(0, currentVertex);
                    line.SetPosition(1, currentVertex);
                    complete2.GetComponent<SpriteRenderer>().enabled = true;
                    stage++;
                }
            }

            if (stage == 2 && estrela3.clicked)
            {
                estrela3.inactive();
                estrela4.active();

                currentVertex = estrela3.vertex;

                mousePos  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                line.SetPosition(1, new Vector3(mousePos.x, mousePos.y, transform.position.z));

                if (estrela4.entered)
                {
                    currentVertex = estrela4.vertex;
                    line.SetPosition(0, currentVertex);
                    line.SetPosition(1, currentVertex);
                    complete3.GetComponent<SpriteRenderer>().enabled = true;
                    stage++;
                }
            }
        }
        else 
        {
            line.SetPosition(1, currentVertex);
            estrela1.clicked = false;
            estrela2.clicked = false;
            estrela3.clicked = false;
            estrela4.clicked = false;

            switch(stage)
            {
                case 0:
                    estrela1.active();
                    estrela2.inactive();
                    break;
                case 1:
                    estrela2.active();
                    estrela3.inactive();
                    break;
                case 2:
                    estrela3.active();
                    estrela4.inactive();
                    break;
            } 
        }
    }
}