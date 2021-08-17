using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBar : MonoBehaviour
{
    public GameObject c1, c2, c3, text, dica;
    private int stage = 0;
    private bool dicaFoi = false;

    public void c1Active()
    {
        c1.SetActive(true);
        stage++;
    }

    public void c2Active()
    {
        c2.SetActive(true);
        stage++;
    }

    public void c3Active()
    {
        c3.SetActive(true);
        stage++;
    }

    private void OnMouseDown()
    {
        if(!dicaFoi)
        {
            dicaFoi = true;
            dica.SetActive(false);
        }

        if(stage < 3)
        {
            text.GetComponent<Animator>().ResetTrigger("showText");
            text.GetComponent<Animator>().SetTrigger("showText");
        } 
    }
}
