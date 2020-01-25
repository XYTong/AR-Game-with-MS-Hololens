using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchSceneCommand : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture

    void OnSelect()
    {
        //music of hitting effect
        //gameObject.GetComponent<AudioSource>().Play();
        //switch to scene 1
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        //Application.LoadLevel("Play");
    }
}
