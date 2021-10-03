using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    GoalController goalController;

    private void Start()
    {
        goalController = GameObject.FindGameObjectWithTag("GoalController").GetComponent<GoalController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        VillagerAi villager = other.GetComponent<VillagerAi>();

        if (villager != null)
            goalController.savedVillager++;
    }

    private void OnTriggerExit(Collider other)
    {
        VillagerAi villager = other.GetComponent<VillagerAi>();

        if (villager != null)
            goalController.savedVillager--;
    }
}
