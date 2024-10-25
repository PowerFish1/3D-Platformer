using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    public GameObject theLogo;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunSplash());
    }



    IEnumerator RunSplash()
    {
        theLogo.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
