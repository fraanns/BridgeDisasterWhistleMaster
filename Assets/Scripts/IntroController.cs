using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class IntroController : MonoBehaviour
{
    PlayableDirector playableDirector;

    bool calledLoad = false;

    private void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();

       
    }
    private void Update()
    {
        if (playableDirector.time > 9.5f && !calledLoad)
        {
            calledLoad = true;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().LoadNextLevel();
        }
    }
}
