using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public Text time;

    private void Update() {
        time.text = GetTimeString(TimeManager.Instance.GetRemainingTime() + 1);
    }

    private string GetTimeString(float timeRemaining) {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        return String.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
