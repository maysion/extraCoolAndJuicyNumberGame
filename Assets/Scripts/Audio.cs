using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    public List<AudioClip> myAudioClipsList = new List<AudioClip>();
    AudioSource audioData;
    int arvausArvo;
    [SerializeField] float aanienAanentaso;
    int sound;

    void Start()
    {

        

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            audioData = GetComponent<AudioSource>();

            //if (ValueHolder.Aanet == 1)
            //{
            //    audioData.volume = 0;
            //}
            //else
            //{
            //    audioData.volume = aanienAanentaso;
            //}
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 2)
        {
            audioData = GetComponent<AudioSource>();

            //if (ValueHolder.Aanet == 1)
            //{
            //    audioData.volume = 0;
            //}
            //else
            //{
            //    audioData.volume = aanienAanentaso;
            //}
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 3)
        {
            audioData = GetComponent<AudioSource>();

            //if (ValueHolder.Aanet == 1)
            //{
            //    audioData.volume = 0;
            //}
            //else
            //{
            //    audioData.volume = aanienAanentaso;
            //}
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
            if (ValueHolder.Aanet == 1)
            {
                //transform.GetComponent<AudioSource>().volume = 0;
                transform.GetComponent<AudioSource>().Play();
            }
            else
            {
                //transform.GetComponent<AudioSource>().volume = aanienAanentaso;
                transform.GetComponent<AudioSource>().Play();
            }
        }
    }

}
