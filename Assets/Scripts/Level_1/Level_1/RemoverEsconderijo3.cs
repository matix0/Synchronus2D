using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverEsconderijo3 : MonoBehaviour
{
    private Animator anim;
    public bool AchouEsconderijo3;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        anim.SetTrigger("ImpedirRemover3");
        AchouEsconderijo3 = true;
    }
}
