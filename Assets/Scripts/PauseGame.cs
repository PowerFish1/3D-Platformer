using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseJingle;
    public AudioSource clickSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!gamePaused)
            {
                pauseJingle.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            
            else
            {
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
                levelMusic.UnPause();
                pauseMenu.SetActive(false);
            }
        }
    }


    public void ResumeGame()
    {
        clickSound.Play();
        levelMusic.UnPause();
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        clickSound.Play();
        levelMusic.UnPause();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void MainMenu()
    {
        clickSound.Play();
        levelMusic.UnPause();
        pauseMenu.SetActive(false);
        Cursor.visible = true;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
