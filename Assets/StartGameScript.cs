using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    void onClick()
    {
        SceneManager.LoadScene("Upgrade");
    }
}