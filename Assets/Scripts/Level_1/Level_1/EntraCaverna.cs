using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntraCaverna : MonoBehaviour
{
    public SceneManager sceneManager;

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Caverna");
    }
}
