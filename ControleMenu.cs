using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMenu : MonoBehaviour {

	public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonOptions()
    {
        SceneManager.LoadScene(2);
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
