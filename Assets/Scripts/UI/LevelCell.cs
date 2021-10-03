using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCell : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text levelNameText;

    int levelId;

    public void SetUp(int levelId, string displayName, bool enabled)
    {
        GetComponentInChildren<Button>().interactable = enabled;

        levelNameText.text = displayName;
        this.levelId = levelId;
    }

    public void LoadLevelButton()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().StartLevel(levelId);
    }
}
