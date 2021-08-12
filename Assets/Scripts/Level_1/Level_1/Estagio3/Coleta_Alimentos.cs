using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleta_Alimentos : MonoBehaviour
{
    private Animator anim;
    public bool Achou_Alimento;
    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        anim.SetTrigger("Clicou");
        Destroy(gameObject, 1);
        Achou_Alimento = true;
    }
}