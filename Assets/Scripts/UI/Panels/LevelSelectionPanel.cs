using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionPanel : Panel
{
    public Transform levelSelectionParent;
    public GameObject levelSelectionPrefab;

    LevelController levelController;

    public override void Open(PanelOpenInfo panelOpenInfo)
    {
        levelController = GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>();


        for (int i = 0; i < levelController.levels.Count; i++)
        {
            GameObject go = Instantiate(levelSelectionPrefab, levelSelectionParent);



            go.GetComponent<LevelCell>().SetUp(levelController.levels[i].levelId, levelController.levels[i].displayName, levelController.InUnlocked (levelController.levels[i].levelId));
        }
    }
}
