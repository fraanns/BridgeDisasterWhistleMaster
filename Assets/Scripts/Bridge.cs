using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bridge : MonoBehaviour
{

    [SerializeField]
    int maxLoad = 5;
    [SerializeField]
    TMP_Text loadText;

    [SerializeField]
    public GameObject visuals;
    [SerializeField]
    public GameObject destroyEffect;

    int currentVillager;

    [SerializeField]
    BoxCollider bridgeModelCollider;

    private void OnTriggerEnter(Collider other)
    {
        VillagerAi villager = other.GetComponent<VillagerAi>();

        if (villager != null)
            currentVillager++;


        if (other.tag == "Player")
            currentVillager++;
    }

    private void OnTriggerExit(Collider other)
    {
        VillagerAi villager = other.GetComponent<VillagerAi>();

        if (villager != null)
            currentVillager--;

        if (other.tag == "Player")
            currentVillager--;
    }

    private void Update()
    {
        if (loadText.enabled)
            loadText.text = $"{currentVillager}/{maxLoad}";


        if (currentVillager > maxLoad)
        {
            destroyEffect.SetActive(true);

            //Destroy(visuals,0.5f);
            Destroy(visuals.GetComponent<BoxCollider>());
            //visuals.GetComponent<MeshRenderer>().enabled = false;

            bridgeModelCollider.enabled = false;

            MeshRenderer[] bridgeVisuals = visuals.GetComponentsInChildren<MeshRenderer>();
            for (int i = 0; i < bridgeVisuals.Length; i++)
            {
                bridgeVisuals[i].enabled = false;
            }

            loadText.enabled = false;

            BoxCollider col = GetComponent<BoxCollider>();

            //Debug.Log(col.size);

            Collider[] cols = Physics.OverlapBox(transform.position, new Vector3(col.size.x * transform.localScale.x, col.size.y * transform.localScale.y, col.size.z * transform.localScale.z), transform.rotation);

            for (int i = 0; i < cols.Length; i++)
            {
                VillagerAi villager = cols[i].GetComponent<VillagerAi>();


                if (villager != null)
                {
                    if (!villager.dead)
                    {

                        Destroy(villager.GetComponent<UnityEngine.AI.NavMeshAgent>());

                        villager.dead = true;

                        villager.GetComponent<Rigidbody>().velocity = Vector3.zero;
                        villager.GetComponent<Rigidbody>().useGravity = true;
                        villager.GetComponent<Rigidbody>().isKinematic = false;
                        villager.GetComponent<Rigidbody>().velocity = transform.forward * 5;


                        GameObject.FindGameObjectWithTag("GoalController").GetComponent<GoalController>().VillagerDead();
                    }
                }
            }
        }
    }
}
