using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBar : MonoBehaviour
{
    public GameObject c1, c2, c3;
    public GameObject text;
    private int stage = 0;

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
        if(stage < 3)
        {
            text.GetComponent<Animator>().SetTrigger("showText");
        } 
    }
}
