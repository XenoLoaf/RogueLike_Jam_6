using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicSelector : MonoBehaviour
{
    public AudioSource MusicPlayer;
    public Slider volSlider;
    public AudioClip[] Music;
    public string[] SongTitles;
    public int TrackPlaying;
    bool TrackChanged = true;
    public TextMeshProUGUI SongNameText;
    public bool MusicPaused = false;

    void Update()
    {
        if (TrackChanged)
        {
            MusicPlayer.PlayOneShot(Music[TrackPlaying], 1);
            TrackChanged = false;
            SongNameText.text = SongTitles[TrackPlaying];
        }
        if((Input.GetKeyDown("z")))
        {
            PreviousTrack();
        }
        if((Input.GetKeyDown("x")))
        {
            NextTrack();
        }
        if((Input.GetKey("c")) && !(Input.GetKey("v")))
        {
            MusicPlayer.volume -= 0.005f;
            volSlider.value = MusicPlayer.volume;
        }
        if((Input.GetKey("v")) && !(Input.GetKey("c")))
        {
            MusicPlayer.volume += 0.005f;
            volSlider.value = MusicPlayer.volume;
        }
        if((Input.GetKeyDown("r")))
        {
            PauseTrack();
        }
    }

    public void NextTrack()
    {
        int Length = Music.Length - 1;
        TrackPlaying += 1;
        MusicPlayer.Stop();
        TrackChanged = true;
        if (TrackPlaying >= Length && TrackPlaying != Length)
        {
            TrackPlaying = 0;
        }
    }

    public void PauseTrack()
    {
        if(MusicPaused == false)
        {
            MusicPaused = true;
            MusicPlayer.Pause();
        }
        else
        {
            MusicPaused = false;
            MusicPlayer.UnPause();
        }
    }

    public void PreviousTrack()
    {
        int Length = Music.Length - 1;
        TrackPlaying -= 1;
        MusicPlayer.Stop();
        TrackChanged = true;
        if (TrackPlaying <= 0 && TrackPlaying != 0)
        {
            TrackPlaying = Length;
        }
    }
}
