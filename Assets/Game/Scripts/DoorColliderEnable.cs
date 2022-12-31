using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using Cinemachine;

public class DoorColliderEnable : MonoBehaviour
{
    private MovingPlatform movingPlatform;
    public GameObject DoorFollowPosition;
    public CinemachineVirtualCamera camera;

    public delegate void disableControls();
    public static event disableControls controlsDisabled;

    private void OnEnable()
    {
        OpeningItemPicker.openingItemGet += EnableCollision;
    }

    private void OnDisable()
    {
        OpeningItemPicker.openingItemGet -= EnableCollision;
    }

    private void Start()
    {
        movingPlatform = GetComponent<MovingPlatform>();
        movingPlatform.enabled = false;
    }


    public void EnableCollision()
    {
        if (gameObject.name == "OpeningDoor")
        {
            movingPlatform.enabled = true;
            movingPlatform.MoveTowardsEnd();
            camera.Follow = DoorFollowPosition.transform;
            StartCoroutine(moveBackToPlayer());

        }
    }


    public void OpenSecondDoor()
    {
        controlsDisabled?.Invoke();
        camera.Follow = DoorFollowPosition.transform;
        movingPlatform.enabled = true;
        movingPlatform.MoveTowardsEnd();
         StartCoroutine(moveBackToPlayer());
        
    }


    IEnumerator moveBackToPlayer()
    {
        yield return new WaitForSeconds(2f);
        camera.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
