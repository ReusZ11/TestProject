using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static UIManager instance; 

    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject LoseUI;
    [SerializeField] private GameObject TimerUI;
    [SerializeField] private GameObject ScoreUI;




    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Lose()
    {
        LoseUI.SetActive(true);
        TimerUI.SetActive(false);
        ScoreUI.SetActive(false);
    }

    public void Win()
    {
        WinUI.SetActive(true);
        TimerUI.SetActive(false);
        ScoreUI.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0); 
    }
}
