using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Fole : MonoBehaviour
{
    //public ZoomInZoomOut AcompanhaCamera;
    public Sprite Fole_Fechada;
    public Sprite Fole_Aberta;
    public SpriteRenderer spriteRenderer;
    public int OrdemClicada = 0;

    // Start is called before the first frame update
 
    void OnMouseDrag()
    {
        spriteRenderer.sprite = Fole_Fechada;
        //OrdemClicada = 1;
    }

    void OnMouseUp()
    {
        //anim.SetTrigger("Clicou");
        spriteRenderer.sprite = Fole_Aberta;
    }
}
