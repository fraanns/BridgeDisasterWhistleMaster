using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePanel : Panel
{
    public TMPro.TMP_Text loseReasonText;

    public class LosePanelOpenInfo : PanelOpenInfo
    {
        public string loseReason;

        public LosePanelOpenInfo(string loseReason)
        {
            this.loseReason = loseReason;
        }
    }

    public override void Open(PanelOpenInfo panelOpenInfo)
    {
        LosePanelOpenInfo openInfo = (LosePanelOpenInfo)panelOpenInfo;

        loseReasonText.text = openInfo.loseReason;
    }


    public void ReloadCurrentLevel()
    {
        UIManager.manager.CloseCurrentPanel();

        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().ReloadCurrentLevel();
    }

    public void LevelSelection()
    {
        UIManager.manager.CloseCurrentPanel();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelController>().StartLevelSelect();
    }
}
