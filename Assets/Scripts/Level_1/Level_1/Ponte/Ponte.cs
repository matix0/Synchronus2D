using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    public int stage = 0;
    public GameObject particles, ponte2, ponte3, ponte4;
    public Controller controller;

    public void updatePonte()
    {
        switch (stage)
        {
            case 1:
                ponte2.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                break;
            case 2:
                ponte3.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                break;
            case 3:
                ponte4.SetActive(true);
                particles.SetActive(false);
                particles.SetActive(true);
                controller.progress += 1;
                controller.updateProgress();
                break;
        }
    }
}
