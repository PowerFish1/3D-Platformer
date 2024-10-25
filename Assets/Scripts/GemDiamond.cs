using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemDiamond: MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;


    void OnTriggerEnter()
    {

        GlobalScore.currentScore += 20000;
        collectSound.Play();
        Destroy(gameObject);
    }

}
