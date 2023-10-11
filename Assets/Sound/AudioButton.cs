using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    public string ButtonType;
    public MusicSelector MusicSelector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (ButtonType == "NextTrack")
        {
            MusicSelector.NextTrack();
        }
        if (ButtonType == "PreviousTrack")
        {
            MusicSelector.PreviousTrack();
        }
    }
}
