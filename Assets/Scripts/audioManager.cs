using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    //Audio sources
    public AudioSource audioSource;
    public AudioSource raceMusic;
    public AudioSource drivingSource;
    public AudioSource accelerationSource;
    public AudioSource driftSource;
    public AudioSource skidSource;

    // audio clips
    public AudioClip drivingSound;
    public AudioClip accelerationSound;
    public AudioClip skidSound1;
    public AudioClip skidSound2;
    public AudioClip honkSound1;
    public AudioClip honkSound2;

    private void Update()
    {
        //HONK!
        if(Input.GetKeyDown(KeyCode.E))
        {
            PlayAudio(skidSource, honkSound1, 0.5f);
        }
    }


    // this function is to play a single audio clip, callable from another script
    // it passes in the desired sound to play and at which volume
    public void PlayAudio(AudioSource source, AudioClip sound, float volume)
    {
        //AudioSource chosenSource = source;
        if(source.isPlaying)
        {
            // do nothing, but WAIT for finish!?
        }
        else
        {
            source.clip = sound; // set the desired sound to play
            source.pitch = Random.Range(0.75f, 1.0f); // shift pitch so sounds aren't always the same
            source.volume = volume; // set volume
            source.Play();  // this plays the sound
        }
    }

    //function to start the race music, callable from other scripts
    public void PlayRaceMusic(float volume)
    {
        raceMusic.volume = volume;
        raceMusic.Play();
    }

    //function to stop the race music, callable from other scripts
    public void StopRaceMusic()
    {
        raceMusic.Stop();
    }
}
