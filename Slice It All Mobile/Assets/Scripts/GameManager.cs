using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.backButtonLeavesApp = true;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    public void TryAgain2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
}
