using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOffImage;
    private bool muted;

    private void Start()
    {
        muted = PlayerPrefs.GetInt("Muted") == 1;
        ImageChange();
        AudioListener.pause = muted;
    }

    private void Update()
    {
        Debug.Log(muted);
    }

    public void MuteButton()
    {
        muted = !muted;
        AudioListener.pause = muted;
        if (muted)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
        ImageChange();
    }

    void ImageChange()
    {
        if (muted)
        {
            soundOffImage.enabled = true;
        }
        else
        {
            soundOffImage.enabled = false;
        }
    }
}
