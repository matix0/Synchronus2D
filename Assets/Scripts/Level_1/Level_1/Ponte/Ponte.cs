using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    public int stage = 0;
    public GameObject particles, ponte2, ponte3, ponte4, complete1, complete2, complete3, martelada;
    public Controller controller;
    public BottomBar bar;

    public void updatePonte()
    {
        switch (stage)
        {
            case 1:
                ponte2.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                complete1.GetComponent<AudioSource>().Play();
                martelada.GetComponent<AudioSource>().Play();
                break;
            case 2:
                ponte3.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                complete2.GetComponent<AudioSource>().Play();
                martelada.GetComponent<AudioSource>().Play();
                break;
            case 3:
                ponte4.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                controller.progress += 1;
                controller.updateProgress();
                bar.c2Active();
                complete3.GetComponent<AudioSource>().Play();
                martelada.GetComponent<AudioSource>().Play();
                break;
        }
    }
}
