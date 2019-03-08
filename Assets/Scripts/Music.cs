using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioLahde;
    //[SerializeField] float aanenTaso;
    int sound;
    string music;
    [SerializeField] float musiikinAanenTaso;

    private void Awake()
    {

        audioLahde = GetComponent<AudioSource>();

        music = ValueHolder.Music;
        if (music == "on")
        {
            Debug.Log("Musiikki on jo päällä");
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
            audioLahde.volume = musiikinAanenTaso;
            audioLahde.Play();
            ValueHolder.Music = "on";
        }
    }

    public void MusiikinAanetPaalle()
    {
        audioLahde.volume = musiikinAanenTaso;
    }
}
