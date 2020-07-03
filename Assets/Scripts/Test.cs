
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //之所以要如此复杂写一个函数接口，是因为UGUI事件函数需要。
    //理论上是可以直接写 public void OnStartGame(){Application.LoadLevel("Game");}
    //但这样一、不规范，二、脚本的复用性大大降低，如果这里有N个地方要实现场景撤换，那么则会有N个脚本
    //所以要这样写，我也不想弄这样的函数接口！-_-!
    public void OnStartGame(string sceneName)
    {
       SceneManager.LoadScene(sceneName);
    }
}
