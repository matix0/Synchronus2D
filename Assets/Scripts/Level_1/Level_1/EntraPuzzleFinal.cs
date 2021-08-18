using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntraPuzzleFinal : MonoBehaviour
{
    public SceneManager sceneManager;

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Puzzle_Final");
    }
}
