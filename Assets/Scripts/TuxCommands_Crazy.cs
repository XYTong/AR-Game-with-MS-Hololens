using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class TuxCommands_Crazy : MonoBehaviour
{
    //global time
    float global_time;
    //generate time
    float times;
    //text to show score
    public GameObject cube;
    TextMeshPro countText;
    //Initialize
    void Start()
    {
        countText = cube.GetComponent<TextMeshPro>();
        times = Random.Range(0, 3);
        global_time = 60;
        setCountText();
    }
    // Called by GazeGestureManager when the user performs a Select gesture

    void OnSelect()
    {
        //synchrone to score-text
        if (global_time >= 0)
        {
            setCountText();
        }
        //music of hitting effect
        gameObject.GetComponent<AudioSource>().Play();
        //disable render and collider of object if being selected
        gameObject.GetComponent<Renderer>().enabled = false;
        transform.GetComponent<Collider>().enabled = false;
        //If the sphere has no Rigidbody component, add one to enable physics.
        //if (!this.GetComponent<Rigidbody>())
        //{
        //var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        //}
    }
    //each frame
    void Update()
    {
        times -= Time.deltaTime; //reduction of time
        if (global_time >= 0)
        {
            global_time -= Time.deltaTime;
            if (times < 0)
            {
                if (gameObject.GetComponent<Renderer>().enabled == false)
                {
                    gameObject.GetComponent<Renderer>().enabled = true;
                    transform.GetComponent<Collider>().enabled = true;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().enabled = false;
                    transform.GetComponent<Collider>().enabled = false;
                }
                times = Random.Range(0, 3);
            }
        }
        else
        {
            SceneManager.UnloadSceneAsync("Play_Crazy");
        }
    }
    void setCountText()
    {
        string str = countText.text;
        int number = int.Parse(str) + 1;
        countText.text = number.ToString();
        //gameObject.Find("Canvas/Count_Text").GetComponent<Text>().text = "Score: " + count;
    }
}
