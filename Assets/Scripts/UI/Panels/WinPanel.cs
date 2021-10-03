using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : Panel
{
    public TMPro.TMP_Text winText;

    public TMPro.TMP_Text perfectText;

    public TMPro.TMP_Text timeText;


    public class WinPanelOpenInfo : PanelOpenInfo {

        public int savedVillager;

        public int maxVillager;

        public WinPanelOpenInfo(int savedVillager, int maxVillager)
        {
            this.savedVillager = savedVillager;
            this.maxVillager = maxVillager;
        }
    }


    public override void Open(PanelOpenInfo panelOpenInfo)
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().WonCurrentLevel();

        WinPanelOpenInfo openInfo = (WinPanelOpenInfo)panelOpenInfo;

        winText.text = $"You saved {openInfo.savedVillager}/{openInfo.maxVillager} villagers";

        perfectText.gameObject.SetActive(openInfo.savedVillager == openInfo.maxVillager);

        timeText.text = $"in {Time.timeSinceLevelLoad.ToString("0.00")}s";
    }

    public void LoadNextLevel()
    {
        UIManager.manager.CloseCurrentPanel();

        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().LoadNextLevel();
    }

    public void LevelSelection()
    {
        UIManager.manager.CloseCurrentPanel();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().StartLevelSelect();
    }
}
