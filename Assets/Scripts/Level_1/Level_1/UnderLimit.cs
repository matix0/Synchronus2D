using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderLimit : MonoBehaviour
{
    public GameObject particulas;
    public Controller controller;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pedra"))
        {
            particulas.SetActive(true);
            controller.progress += 1;
            controller.updateProgress();
        }

        if (collision.gameObject.CompareTag("Pedras"))
        {
            controller.progress += 1;
            controller.updateProgress();
        }

        Destroy(collision.gameObject);
    }
}
