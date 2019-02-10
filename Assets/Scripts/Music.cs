using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] float aanenTaso;
    public int sound;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = aanenTaso;
        _audioSource.loop = true;
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void aaniPoisPaalle()
    {
        sound = ValueHolder.Sound;
        if (sound == 0)
        {
            _audioSource.volume = aanenTaso;
        }
        else
        {
            _audioSource.volume = 0;
        }
    }

}
