using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject fellText;
    public GameObject levelAudio;
    public GameObject fadeOut;
    public static bool isDie = false;


    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        isDie = true;
        fellText.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
        isDie = false;
        GlobalScore.currentScore = 0;
    }

}
