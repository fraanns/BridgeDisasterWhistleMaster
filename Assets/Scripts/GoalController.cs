using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Image savedVillagerProgressImage;
    public TMPro.TMP_Text savedVillagerProgressText;

   
    [HideInInspector]
    public int savedVillager;
    
    private int villagerInLevel = 10;

    public GameObject completeLevelPrompt;

    int deadVillager = 0;

    bool lost = false;
    bool won = false;

    
    private void Start()
    {
        villagerInLevel = GameObject.FindGameObjectsWithTag("Villager").Length;

        InputReader.input.levelCompleteEvent += OnLevelComplete;
    }

    

    private void Update()
    {
        savedVillagerProgressImage.fillAmount = (float)savedVillager / villagerInLevel;
        savedVillagerProgressText.text = $"{savedVillager}/{villagerInLevel}";

        if (savedVillager >= villagerInLevel && !UIManager.manager.AnyPanelsOpen() && !won)
        {
            UIManager.manager.OpenPanel<WinPanel>(new WinPanel.WinPanelOpenInfo (savedVillager, villagerInLevel), false);
            won = true;

            completeLevelPrompt.SetActive(false);
        }
        else
        {
            if (savedVillager >= 1 && !won)
            {
                completeLevelPrompt.SetActive(true);
            }
        }

        if (deadVillager >= villagerInLevel && !lost)
        {
            lost = true;
            UIManager.manager.OpenPanel<LosePanel>(new LosePanel.LosePanelOpenInfo("All villager have died!"), false);
        }
    }

    private void OnLevelComplete()
    {
        if (savedVillager >= 1 && !won)
        { 
            UIManager.manager.OpenPanel<WinPanel>(new WinPanel.WinPanelOpenInfo(savedVillager, villagerInLevel), false);
            won = true;
        }   
    }

    public void VillagerDead()
    {
        deadVillager++;
    }

    public void PlayerFall()
    {
        if (!lost)
        {
            UIManager.manager.OpenPanel<LosePanel>(new LosePanel.LosePanelOpenInfo("You have fallen to your death!"), false);
            lost = true;
        }
    }
}
