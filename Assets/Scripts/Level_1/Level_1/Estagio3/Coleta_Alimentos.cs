using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleta_Alimentos : MonoBehaviour
{
    private Animator anim;
    public bool Achou_Alimento;
    private Abre_Tenda Tenda;
    public BoxCollider2D Colisor;
    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
        Colisor.enabled = false;
    }

    private void OnMouseDown()
    {


        anim.SetTrigger("Clicou");
        Destroy(gameObject, 1);
        Achou_Alimento = true;


    }
}