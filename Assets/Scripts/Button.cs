using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    Music AudioMusic = new Music();
    Audio AudioSound = new Audio();

    [SerializeField] public float aanenTasoLmao;

    public Sprite sound_off;
    public Sprite sound_on;
    public Image but;
    public void Start()
    {

        //var aani = GameObject.Find("Music"); // find the object
        //aani.transform.GetComponent(audioLahde).MusiikinAanetPaalle();

        if (ValueHolder.Aanet == 1)
        {
            but.sprite = sound_on;
            AudioListener.volume = 0;
        }
        else
        {
            but.sprite = sound_off;
            ValueHolder.Aanet = 2;
            AudioListener.volume = aanenTasoLmao;
            //AudioMusic.MusiikinAanetPaalle();
        }
    }

    public void ChangeImage()
    {
        if (but.sprite == sound_off)
        {
            but.sprite = sound_on;
            AudioListener.volume = 0;
            ValueHolder.Aanet = 1;
        }   
        else
        {
            but.sprite = sound_off;
            ValueHolder.Aanet = 2;
            AudioListener.volume = aanenTasoLmao;
            //AudioMusic.MusiikinAanetPaalle();
        }

    }
}
