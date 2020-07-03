using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMount_Click : MonoBehaviour
{

    public Button mButton;

    // Use this for initialization
    void Start()
    {
        //Gets ButtonMount
        Button btnMount = mButton.GetComponent<Button>();
        //add a listener to ButtonMount, executing TaskOnClick() when click ButtonMount
        // btnMount.onClick.AddListener(TaskOnClick);
    }

    void OnSelect()
    {
        //Loading Scene1
        SceneManager.LoadScene(1); ;
    }
}