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

    void Start()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 2)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
        }
        else if (currentSceneIndex == 3)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
        }
    //    else if (currentSceneIndex == 1)
    //    {
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/reaktioaani1"));
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/reaktioaani2"));
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/reaktioaani3"));
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/reaktioaani4"));
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/reaktioaani5"));
    //    }
    //    else if (currentSceneIndex == 2)
    //    {
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/pelaajavoittaa"));
    //    }
    //    else
    //    {
    //        myAudioClipsList.Add((AudioClip)Resources.Load(" audio/konevoittaa"));
    //    }

    }

    public void PelaaAani()
    {
        arvausArvo = ValueHolder.GuessCounter;
        if (arvausArvo != 0)
        {
        transform.GetComponent<AudioSource>().clip = myAudioClipsList[Random.Range(0, myAudioClipsList.Count)];
        transform.GetComponent<AudioSource>().Play();
        }
    }


}
