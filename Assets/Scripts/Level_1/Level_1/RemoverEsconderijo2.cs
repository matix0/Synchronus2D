using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverEsconderijo2 : MonoBehaviour
{
    private Animator anim;
    public bool AchouEsconderijo2;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        anim.SetTrigger("ImpedirRemover2");
        AchouEsconderijo2 = true;
    }
}
