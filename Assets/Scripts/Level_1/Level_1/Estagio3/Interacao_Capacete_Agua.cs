using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Capacete_Agua : MonoBehaviour
{
    public Sprite Capacete_Frio;
    public SpriteRenderer spriteRenderer;
    public bool Entrou_Balde;
    public Interacao_Cobre_Bigorna bigorna;
    // Start is called before the first frame update
    public void OnTriggerStay2D(Collider2D collision)
    {
        Entrou_Balde = true;
    }

    public void OnMouseDown(Collider2D collision)
    {

    }
}