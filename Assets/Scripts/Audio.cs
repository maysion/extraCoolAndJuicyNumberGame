using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    public List<AudioClip> myAudioClipsList = new List<AudioClip>();
    AudioSource audioData;
    public int arvausArvo;
    [SerializeField] float aanenTaso;
    public int sound;

    void Start()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            audioData = GetComponent<AudioSource>();
            sound = ValueHolder.Sound;
            if (sound == 1)
            {
                audioData.volume = aanenTaso;
            }
            else
            {
                audioData.volume = 0;
            }
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 2)
        {
            audioData = GetComponent<AudioSource>();
            sound = ValueHolder.Sound;
            if (sound == 1)
            {
                audioData.volume = aanenTaso;
            }
            else
            {
                audioData.volume = 0;
            }
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 3)
        {
            audioData = GetComponent<AudioSource>();
            sound = ValueHolder.Sound;
            if (sound == 1)
            {
                audioData.volume = aanenTaso;
            }
            else
            {
                audioData.volume = 0;
            }
            audioData.Play(0);
            Debug.Log("started");
        }
    
    }

    public void PelaaAani()
    {
        arvausArvo = ValueHolder.GuessCounter;
        if (arvausArvo != 0)
        {
            transform.GetComponent<AudioSource>().clip = myAudioClipsList[Random.Range(0, myAudioClipsList.Count)];
            sound = ValueHolder.Sound;
            if (sound == 1)
            {
                transform.GetComponent<AudioSource>().volume = aanenTaso;
            }
            else
            {
                transform.GetComponent<AudioSource>().volume = 0;
            }
            transform.GetComponent<AudioSource>().Play();
        }
    }

}
