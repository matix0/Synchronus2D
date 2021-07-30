using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoEscudo : MonoBehaviour
{
    private Animator anim;
    int clicked = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (clicked == 0)
        {
            anim.SetTrigger("faderTerra");
            clicked++;
            return;
        }
        if (clicked == 1)
        {
            anim.SetTrigger("faderEscudo");
            clicked++;
            return;
        }

    }
}
