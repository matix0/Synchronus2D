using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverEsconderijo : MonoBehaviour
{
    private Animator anim;
    public bool AchouEsconderijo;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        anim.SetTrigger("ImpedirRemover");
        AchouEsconderijo = true;
    }
}
