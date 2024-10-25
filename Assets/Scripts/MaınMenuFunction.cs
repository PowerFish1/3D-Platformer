using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MaınMenuFunction : MonoBehaviour
{
    public AudioSource clickButton;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Update()
    {
        Cursor.visible = true;
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best Score: " + bestScore;
    }


    public void PlayGame()
    {
        clickButton.Play();
        RedirectToLevel.redirectToLevel = 4;
        SceneManager.LoadScene(4);
    }


    public void Credits()
    {
        clickButton.Play();
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        clickButton.Play();
        Application.Quit();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}
