using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region singleton

    private static SoundManager _instance = null;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: SoundManager Not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public AudioClip scoreNormal;
    public AudioClip scoreCombo;
    public AudioClip wrongMove;
    public AudioClip tap;

    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayScore(bool isCombo)
    {
        if (isCombo) {
            audioSource.PlayOneShot(scoreCombo);
        } else {
            audioSource.PlayOneShot(scoreNormal);
        }
    }

    public void PlayWrong()
    {
        audioSource.PlayOneShot(wrongMove);
    }
    
    public void PlayTap()
    {
        audioSource.PlayOneShot(tap);
    }
}
