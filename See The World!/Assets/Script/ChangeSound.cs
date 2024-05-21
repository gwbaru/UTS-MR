using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audiosource;

    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            audiosource.Stop();
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audiosource.Play();
        }
    }
}
