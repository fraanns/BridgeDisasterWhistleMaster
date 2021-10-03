using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : Panel
{
    public override void Open(PanelOpenInfo panelOpenInfo)
    {
       
    }

    public void StartGame()
    {
        UIManager.manager.CloseCurrentPanel();

        UIManager.manager.OpenPanel<LevelSelectionPanel>(null, false);
        //GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateController>().StartGame();
    }
}
