using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcenderTemplo : MonoBehaviour
{
    //[HideInInspector]
    public Sprite espadaNoLocal;
    //[HideInInspector]
    public Sprite escudoNoLocal;
    //[HideInInspector]
    public Sprite espadaForaDoLocal;
    //[HideInInspector]
    public Sprite escudoForaDoLocal;
    //[HideInInspector]
    public Sprite temploLocal;
    //[HideInInspector]
    public GameObject objectEspada;
    //[HideInInspector]
    public GameObject objectEscudo;
    //[HideInInspector]
    public GameObject acendeTemplo;

    private bool espadaTransformada = false;
    private bool escudoTransformado = false;

    private Animator animEspada;
    private Animator animEscudo;
    private Animator animCam;

    private BoxCollider2D colEspada, colEscudo;

    //[HideInInspector]
    public Camera currentCamera;

    void Start()
    {
        animEspada = objectEspada.GetComponent<Animator>();
        animEscudo = objectEscudo.GetComponent<Animator>();
        animCam = currentCamera.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Espada"))
        {
            objectEspada.GetComponent<SpriteRenderer>().sprite = espadaNoLocal;
            espadaTransformada = true;
        }

        if (collision.CompareTag("Escudo"))
        {
            objectEscudo.GetComponent<SpriteRenderer>().sprite = escudoNoLocal;
            escudoTransformado = true;
        }

        if (espadaTransformada == true && escudoTransformado == true)
        {
            //Ativar Animator Espada e Escudo pra Tocar o Fade
            animEspada.enabled = true;
            animEscudo.enabled = true;

            //Acender caso espada e escudo no collider
            acendeTemplo.GetComponent<SpriteRenderer>().sprite = temploLocal;
            animEspada.SetTrigger("ImpedirFaderEspada");
            animEscudo.SetTrigger("ImpedirFaderEscudo");

            //Cam animation
            currentCamera.orthographicSize = 6f;
            animCam.enabled = true;
            animCam.SetTrigger("ImpedCam");
        }
    }
    private void OnTriggerExit2D(Collider2D collision2)
    {
        if (collision2.CompareTag("Espada"))
        {
            objectEspada.GetComponent<SpriteRenderer>().sprite = espadaForaDoLocal;
            espadaTransformada = false;
        }
        if (collision2.CompareTag("Escudo"))
        {
            objectEscudo.GetComponent<SpriteRenderer>().sprite = escudoForaDoLocal;
            escudoTransformado = false;
        }
    }
}
