using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camerapenhasco : MonoBehaviour
{
    public GameObject playerController;

    public void animPlayerController()
    {
        playerController.GetComponent<Animator>().SetTrigger("playerMove");
    }

    public void changeScene()
    {
        SceneManager.LoadScene("Level_1.1");
    }
}
