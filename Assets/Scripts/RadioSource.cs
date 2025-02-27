using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSource : MonoBehaviour
{
    private AudioSource musicplayer;
    public AudioClip backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        musicplayer = GetComponent<AudioSource>();
        //playSound(backgroundMusic, musicplayer);
    }

    // Update is called once per frame
    public void playSound(Collider other)
    {
        if (other.tag == "Player")
        {
            //musicplayer.Stop();
            //musicplayer.clip = backgroundMusic;
            //audioPlayer.time = 0;
            musicplayer.Play();
        }
        else
            musicplayer.Stop();
    }
}
