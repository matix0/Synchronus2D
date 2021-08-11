using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcenderTemplo : MonoBehaviour
{
    public Sprite espadaNoLocal;
    public Sprite escudoNoLocal;
    public Sprite temploLocal;
    public GameObject objectEspada;
    public GameObject objectEscudo;
    public GameObject acendeTemplo;
    private bool espadaTransformada = false;
    private bool escudoTransformado = false;
    private Animator animEspada;
    private Animator animEscudo;

    void Start()
    {
        animEspada = objectEspada.GetComponent<Animator>();
        animEscudo = objectEscudo.GetComponent<Animator>();
        //anim = GetComponent<Animator>();
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
            acendeTemplo.GetComponent<SpriteRenderer>().sprite = temploLocal;
            animEspada.SetTrigger("ImpedirFaderEspada");
            animEscudo.SetTrigger("ImpedirFaderEscudo");
        }
    }
}
