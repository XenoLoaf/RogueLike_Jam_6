using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantTransition : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("GameScene");
    }
}
