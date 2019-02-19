using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audioSource;
    //[SerializeField] float aanenTaso;
    int sound;
    string music;
    [SerializeField] float aanenTaso;

    private void Awake()
    {
        music = ValueHolder.Music;
        if (music == "on")
        {
            Debug.Log("Musiikki on jo päällä");
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();
            AudioListener.volume = aanenTaso;
            _audioSource.Play();
            ValueHolder.Music = "on";
        }
    }

    //public void MutetaAani()
    //{
    //    sound = ValueHolder.Sound;
    //    if (sound == 1)
    //    {

    //    }
    //}

}
