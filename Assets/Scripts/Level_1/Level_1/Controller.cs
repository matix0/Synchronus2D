using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Camera currentCamera;
    public int progress = 0;
    private Animator anim;

    private void Start()
    {
        anim = currentCamera.GetComponent<Animator>();
    }

    public void updateProgress()
    {
        if (progress >= 3)
        {

            currentCamera.orthographicSize = 6f;
            anim.enabled = true;
            anim.SetTrigger("complete");
        }
    }
}
