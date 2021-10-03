using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GoalController").GetComponent<GoalController>().PlayerFall();
        }
    }
}
