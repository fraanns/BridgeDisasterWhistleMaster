using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public List<Level> levels = new List<Level>();

    int currentLevel = 0;

    [System.Serializable]
    public class Level
    {
        public string displayName;
        public int levelId;
    }

    string currentLevelName;

    private void Start()
    {
        wonLevels.Add(1);
    }

    public void StartLevel(int levelId)
    {
        currentLevel = levelId;


        SceneManager.LoadScene(levelId, LoadSceneMode.Additive);
        currentLevelName = SceneManager.GetSceneByBuildIndex(levelId).name;

        UIManager.manager.CloseCurrentPanel();

        GetComponent<GameStateController>().StartGame();
    }

    public void LoadNextLevel()
    {
        AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(currentLevelName);
        currentLevel++;
        asyncOperation.completed += OnUnloadSceneComplete;
    }

    public void ReloadCurrentLevel()
    {
        AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(currentLevelName);
   
        asyncOperation.completed += OnUnloadSceneComplete;
    }

    private void OnUnloadSceneComplete(AsyncOperation obj)
    {
        

        if (SceneManager.sceneCountInBuildSettings > currentLevel)
        {
            SceneManager.LoadScene(currentLevel,LoadSceneMode.Additive);

            currentLevelName = SceneManager.GetSceneByBuildIndex(currentLevel).name;

        }
        else
        {
            UIManager.manager.OpenPanel<LevelSelectionPanel>(null, false);
            GetComponent<GameStateController>().StartMenu();
        }

    }

    public void StartLevelSelect()
    {
        SceneManager.UnloadSceneAsync(currentLevel);

        GetComponent<GameStateController>().StartMenu();

        UIManager.manager.OpenPanel<LevelSelectionPanel>(null, false);
    }

    List<int> wonLevels = new List<int>();
    public void WonCurrentLevel()
    {
        wonLevels.Add(currentLevel);
    }

    public bool InUnlocked(int levelId)
    {
        //return true;
        return wonLevels.Contains(levelId);
    }
}
