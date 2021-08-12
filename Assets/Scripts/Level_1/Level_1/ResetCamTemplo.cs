using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamTemplo : MonoBehaviour
{
    private void resetAnimator()
    {
        GetComponent<Animator>().enabled = false;
    }
}
