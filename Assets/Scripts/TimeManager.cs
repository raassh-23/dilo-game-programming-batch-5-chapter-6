using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    #region singleton

    private static TimeManager _instance = null;

    public static TimeManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<TimeManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager Not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int duration;

    private float time;

    private void Start() {
        time = 0;
    }

    private void Update() {
        if (GameFlowManager.Instance.IsGameOver) {
            return;
        }

        if (time > duration) {
            GameFlowManager.Instance.GameOver();
            return;
        }

        time += Time.deltaTime;
    }

    public float GetRemainingTime() {
        return duration - time;
    }
}
