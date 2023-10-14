using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    public string ButtonType;
    public MusicSelector MusicSelector;

    void OnMouseDown()
    {
        if (ButtonType == "NextTrack")
        {
            MusicSelector.NextTrack();
        }
        if (ButtonType == "PauseTrack")
        {
            MusicSelector.PauseTrack();
        }
        if (ButtonType == "PreviousTrack")
        {
            MusicSelector.PreviousTrack();
        }
    }
}
