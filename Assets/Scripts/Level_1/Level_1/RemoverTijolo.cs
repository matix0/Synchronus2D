using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverTijolo : MonoBehaviour
{
    private Animator anim;
    public bool AchouTijolo;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Clicou");
        AchouTijolo = true;
    }
}
