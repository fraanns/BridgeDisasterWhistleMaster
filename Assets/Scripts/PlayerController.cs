using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    Transform whistleEffectRangeIndicator;
    [SerializeField]
    float maxWhistleRange = 10;
    [SerializeField]
    float whistleVolumeIncreaseSpeed = 4;

    Animator anim;

    InputReader input;

    Camera cam;

    //CharacterController con;

    bool whisteling = false;

    Rigidbody rb;

    void Start() {

        input = InputReader.input;

        input.whistleStartEvent += OnWhistleStart;
        input.whistleEndEvent += OnWhistleEnd;

        cam = Camera.main;

        anim = GetComponent<Animator>();
        //con = GetComponent<CharacterController>();#
        rb = GetComponent<Rigidbody>();
    }
    private void OnDestroy()
    {
        input.whistleStartEvent -= OnWhistleStart;
        input.whistleEndEvent -= OnWhistleEnd;
    }

    private void OnWhistleStart()
    {
        whisteling = true;

        whistleEffectRangeIndicator.gameObject.SetActive(true);
        whistleEffectRangeIndicator.localScale = Vector3.zero;
    }
    private void OnWhistleEnd()
    {

        whisteling = false;

        whistleEffectRangeIndicator.gameObject.SetActive(false);

        Collider[] cols = Physics.OverlapSphere(transform.position, whistleEffectRangeIndicator.localScale.x);

        for (int i = 0; i < cols.Length; i++)
        {
            VillagerAi villiger = cols[i].GetComponent<VillagerAi>();

            if (villiger != null)
            {
                villiger.Follow();
            }
        }

        primeVilliger.Clear();
    }

    List<VillagerAi> primeVilliger = new List<VillagerAi>();

    private void Update()
    {
        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = forward * input.moveDirection.y + right * input.moveDirection.x;


        anim.SetBool("run", desiredMoveDirection.magnitude > 0.2f);

        if (desiredMoveDirection.magnitude > 0.2f)
            transform.rotation = Quaternion.LookRotation(desiredMoveDirection);

        //if (con.isGrounded)
        //con.Move(desiredMoveDirection * Time.deltaTime * movementSpeed);
        //else
        //con.SimpleMove(desiredMoveDirection * Time.deltaTime * movementSpeed);

        transform.position += desiredMoveDirection * Time.deltaTime * movementSpeed;
        //rb.MovePosition(transform.position + (desiredMoveDirection * Time.deltaTime * movementSpeed));

        if (whisteling)
        {
            Collider[] cols = Physics.OverlapSphere(transform.position, whistleEffectRangeIndicator.localScale.x);

            for (int i = 0; i < cols.Length; i++)
            {
                VillagerAi villiger = cols[i].GetComponent<VillagerAi>();

                if (villiger != null)
                {
                    if (!primeVilliger.Contains(villiger))
                    {
                        villiger.Prime();

                        primeVilliger.Add(villiger);
                    }

                }
            }


            if (whistleEffectRangeIndicator.localScale.x < maxWhistleRange)
                whistleEffectRangeIndicator.localScale = whistleEffectRangeIndicator.localScale + Vector3.one * Time.deltaTime * whistleVolumeIncreaseSpeed;
        }
    }
}
