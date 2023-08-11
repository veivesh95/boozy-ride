using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GUIClass : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }    
}
