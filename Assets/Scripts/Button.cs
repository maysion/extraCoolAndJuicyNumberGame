using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    public Sprite sound_off;
    public Sprite sound_on;
    public Image but;
    [SerializeField] float aanenTaso;

    public void ChangeImage()
    {
        if (but.sprite == sound_off)
        {
            but.sprite = sound_on;
            AudioListener.volume = 0;
        }   
        else
        {
            but.sprite = sound_off;
            AudioListener.volume = aanenTaso;
        }

    }
}
