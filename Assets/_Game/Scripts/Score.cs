using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    private int scoreValue;
    [SerializeField] private int valueToWin;

    [SerializeField] private TMP_Text scoreText;
    private void Awake()
    {
        EventManager.OnDestroyCoin.AddListener(AddScore);
        scoreValue = 0;
    }

    public void AddScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString();

        if (scoreValue == valueToWin)
        {
            GameManager.instance.GameWin();
        }
    }
}
