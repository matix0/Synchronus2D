using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abre_Tenda : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    Collider2D Colisor;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        anim.SetTrigger("Clicou");
        Destroy(gameObject, 1);

    }
}
