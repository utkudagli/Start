using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    private Button start;
    public int status = 0;
    private Text timer;
    private Text text;
    public StartLight lights;
    float startTime = 0;
    public float fTimer = 0;
    bool isZero = true;
    public bool timerisRunning = true;
    public GameObject username;
    public static string result;
    public int timeFormat;
    public Button leaderboard;
    PlayfabManager pfm;

    // Start is called before the first frame update
    void Start()
    {
        start = GetComponent<Button>();
        timer = transform.parent.gameObject.transform.GetChild(1).GetComponent<Text>();
        text = transform.parent.gameObject.transform.GetChild(2).GetComponent<Text>();
        leaderboard = transform.parent.gameObject.transform.GetChild(3).GetComponent<Button>();

        username = transform.parent.gameObject.transform.GetChild(4).gameObject;
        GameObject sLight = GameObject.Find("StartingLights");
        StartLight startLight = sLight.GetComponent<StartLight>();
        start.onClick.AddListener(StartorGo);
        leaderboard.onClick.AddListener(OpenLeaderboard);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (lights.lightStatus == 0 && lights.lTimer == 0 && timerisRunning)
        {
            fTimer = startTime + Time.time;
            fTimer = fTimer - lights.Counter;
            timer.text = FormatTime(fTimer);
        }
    }

    string FormatTime(float time)
    {
        int intTime = (int)time;
        int sec = intTime % 60;
        float ms = time * 1000;
        ms = (ms % 1000);
        string timeString = string.Format("{0:00}:{1:000}", sec, ms);
        sec = sec * 1000;
        timeFormat = sec + (int)ms;
        timeFormat = timeFormat * -1;
        Debug.Log(timeFormat);
        return timeString;
    }

    // Update is called once per frame
    void StartorGo()
    {
        //if status is 0 it means game didn't started. If 1 it means game started.
        if (status == 0)
        {
            status = 1;
            timerisRunning = true;
        }
        else if(status == 1)
        {
            Debug.Log("deneme");
            WinCondition();
        }

    }

    void WinCondition()
    {
        if (lights.lTimer > 0)
        {
            status = 0;
            timer.text = "JUMP START!";
            Time.timeScale = 0;
            text.text = "To reset press on Start again";
            start.onClick.AddListener(Reset);
        }
        else
        {
            status = 0;
            result = timer.text;
            timerisRunning = false;
            Time.timeScale = 0;
            text.text = "To reset press on Start again";
            start.onClick.AddListener(Reset);
            PlayfabManager.SendLeaderboard(timeFormat);
            //username.SetActive(true);
        }
    }
    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene", 0);
    }

    public void OpenLeaderboard()
    {
        //pfm.GetLeaderboard();
        SceneManager.LoadScene("Leaderboard", 0);
    }
}
