using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abre_Tenda : MonoBehaviour
{
    public bool AbriuTenda = false;
    private Animator anim;
    public Coleta_Alimentos Alimentos;

    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        anim.SetTrigger("Clicou");
        Destroy(gameObject, 1);
        AbriuTenda = true;
        Alimentos.Colisor.enabled = true;

    }
}
