using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public List<AudioClip> Music;
    AudioSource _audio;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (!_audio.isPlaying)
        {
            _audio.clip = Music[Random.Range(0, Music.Count)];
            _audio.Play();
        }
    }
}
