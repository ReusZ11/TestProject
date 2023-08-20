using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time;

    [SerializeField] private TMP_Text timerText;

    private float timeMax = 15f;
    private float timeLeft = 0f;

    private void Awake()
    {
        EventManager.OnAddTime.AddListener(AddTime);
        timeLeft = time;
    }

    private void Start()
    {
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1.0f);
            timeLeft--;
        }

        FinishGame();
    }

    private void Update()
    {
        UpdateTimeText();
    }
    void FinishGame()
    {
        GameManager.instance.GameLose();
    }
    private void UpdateTimeText()
    {
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        int seconds = (int)timeLeft;
        timerText.text = seconds.ToString();
    }

    public void AddTime()
    {
        timeLeft += 5f;
        if (timeLeft > timeMax)
        {
            timeLeft = timeMax;
        }
        //Debug.Log("ADDED");
    }
}