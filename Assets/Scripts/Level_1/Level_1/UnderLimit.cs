using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderLimit : MonoBehaviour
{
    public GameObject particulas, audioPedra;
    public Controller controller;
    public BottomBar bar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pedra"))
        {
            particulas.SetActive(true);
            controller.progress += 1;
            controller.updateProgress();
            bar.c1Active();
            audioPedra.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.CompareTag("Pedras"))
        {
            controller.progress += 1;
            controller.updateProgress();
            bar.c3Active();
        }

        Destroy(collision.gameObject);
    }
}
