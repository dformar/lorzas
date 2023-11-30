using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject mouth;

    [SerializeField]
    private GameObject player;
    private GameObject pickedObject = null;
    private ThirdPersonController playerSpeed, playerSpeedBefore;
    private StarterAssetsInputs playerJumpAndSprint, playerJumpAndSprintBefore;
    [SerializeField]
    private const float NORMAL_WEIGHT_SPEED = 2, HEAVY_WEIGHT_SPEED = 1;

    private bool isGround, isBiting = false;

    private Transform parentBefore;

    private void Start()
    {
        playerSpeed = player.GetComponent<ThirdPersonController>();
        playerSpeedBefore = new ThirdPersonController();
        playerJumpAndSprint = player.GetComponent<StarterAssetsInputs>();
        playerJumpAndSprintBefore = new StarterAssetsInputs();
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedObject != null)
        {
            if (Input.GetKey("r") || Input.GetMouseButton(1))
            {
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(parentBefore);
                pickedObject = null;
                playerSpeed.MoveSpeed = playerSpeedBefore.MoveSpeed;
                playerJumpAndSprint.jump = playerJumpAndSprintBefore.jump;
                playerJumpAndSprint.sprint = playerJumpAndSprintBefore.sprint;
                isBiting = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }

        if (isBiting)
        {
            playerJumpAndSprint.jump = false;
            playerJumpAndSprint.sprint = false;
        }

        if (isGround &&
            (other.gameObject.CompareTag("LightWeight") ||
            other.gameObject.CompareTag("NormalWeight") ||
            other.gameObject.CompareTag("HeavyWeight")))
        {
            if ((Input.GetKey("e") || Input.GetMouseButton(0)) && pickedObject == null)
            {
                parentBefore = other.gameObject.transform.parent;

                playerSpeedBefore.MoveSpeed = playerSpeed.MoveSpeed;
                playerJumpAndSprintBefore.jump = playerJumpAndSprint.jump;
                playerJumpAndSprintBefore.sprint = playerJumpAndSprint.sprint;

                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.transform.SetParent(mouth.gameObject.transform);
                pickedObject = other.gameObject;

                if (other.gameObject.CompareTag("NormalWeight"))
                {
                    playerSpeed.MoveSpeed = NORMAL_WEIGHT_SPEED;
                }

                if (other.gameObject.CompareTag("HeavyWeight"))
                {
                    playerSpeed.MoveSpeed = HEAVY_WEIGHT_SPEED;
                }

                isBiting = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
