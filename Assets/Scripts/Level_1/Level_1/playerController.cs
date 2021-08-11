using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject Gani;
    public GameObject cameraAnim;

    public void playerWalk()
    {
        Gani.GetComponent<Animator>().SetTrigger("walk");
    }

    public void playerIdle()
    {
        Gani.GetComponent<Animator>().SetTrigger("idle");
    }

    public void camZoom()
    {
        cameraAnim.GetComponent<Animator>().SetTrigger("zoom");
    }
}
