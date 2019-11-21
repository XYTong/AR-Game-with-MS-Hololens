using UnityEngine;
using System.Collections;

public class SphereCommands : MonoBehaviour
{
    //generate time
    float times;
    //Initialize
    void Start()
    {
        times = Random.Range(0, 10);
    }
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        //If the sphere has no Rigidbody component, add one to enable physics.
        //if (!this.GetComponent<Rigidbody>())
        //{
        //var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        //}
        Destroy(gameObject);
    }

    //each frame
    void Update()
    {
        times -= Time.deltaTime; //reduction of time
        if (times < 0)
        {
            if (gameObject.GetComponent<Renderer>().enabled == false)
            {
                gameObject.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                gameObject.GetComponent<Renderer>().enabled = false;
            }
            times = Random.Range(0, 10);
        }
    }
}
