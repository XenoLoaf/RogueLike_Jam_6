using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSelector : MonoBehaviour
{
    public AudioSource MusicPlayer;
    public AudioClip[] Music;
    public string[] SongTitles;
    public int TrackPlaying;
    bool TrackChanged = true;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TrackChanged)
        {
                     MusicPlayer.PlayOneShot(Music[TrackPlaying], 1);
                     TrackChanged = false;
        }
        text.text = SongTitles[TrackPlaying];

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
