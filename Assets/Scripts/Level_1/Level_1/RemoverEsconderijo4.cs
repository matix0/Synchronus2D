using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverEsconderijo4 : MonoBehaviour
{
    private Animator anim;
    public bool AchouEsconderijo4;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        anim.SetTrigger("ImpedirRemover4");
        AchouEsconderijo4 = true;
    }
}
