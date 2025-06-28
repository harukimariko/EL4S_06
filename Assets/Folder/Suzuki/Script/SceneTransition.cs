using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public GameObject SceneCon;
    SceneController scenecontroller;
    void Start()
    {
        scenecontroller = SceneCon.GetComponent<SceneController>();
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scenecontroller.SceneLoader();
        }
    }
}
