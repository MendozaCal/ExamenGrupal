using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Saltodeescena : MonoBehaviour
{
    public void JumpScene(int a)
    {
        SceneManager.LoadScene(a);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
