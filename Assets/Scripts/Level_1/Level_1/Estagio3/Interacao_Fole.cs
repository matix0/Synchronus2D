using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao_Fole : MonoBehaviour
{
    //public ZoomInZoomOut AcompanhaCamera;
    public Sprite Fole_Fechada;
    public Sprite Fole_Aberta;
    public SpriteRenderer spriteRenderer;
    public bool ApertouFole = false;
    public Interacao_Cobre_Bigorna cobre;


    // Start is called before the first frame update

    void OnMouseDrag()
    {
        spriteRenderer.sprite = Fole_Fechada;
        
    }

    void OnMouseUp()
    {
        spriteRenderer.sprite = Fole_Aberta;
        ApertouFole = true;
        cobre.colisor.enabled = true;
    }
}
