using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverMatinho : MonoBehaviour
{
    private Animator anim;
    public bool AchouMatinho;
    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    
    private void OnMouseDown()
    {
        anim.SetTrigger("Clicou");
        AchouMatinho = true;
    }
}
