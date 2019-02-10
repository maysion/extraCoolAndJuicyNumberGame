using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Sprite sound_off;
    public Sprite sound_on;
    public Image but;

    public void ChangeImage()
    {
        if (but.sprite == sound_off)
        {
            but.sprite = sound_on;
            ValueHolder.Sound = 1;
        }   
        else
        {
            but.sprite = sound_off;
            ValueHolder.Sound = 0;
        }

    }
}
