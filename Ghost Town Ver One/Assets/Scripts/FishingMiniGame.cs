using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class FishingMiniGame : MonoBehaviour
{
    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform fish;

    float fishPosition;
    float fishDestination;

    float fishTimer;
    [SerializeField] float timeMultiplicator = 3f;

    float fishSpeed;
    [SerializeField] float smoothMotion = 1f;

    [SerializeField] Transform hook;
    float hookPosition;
    [SerializeField] float hookSize = 0.1f;
    [SerializeField] float hookPower = 0.5f;
    float hookProgress;
    float hookPullVelocity;
    [SerializeField] float hookPullPower = 0.01f;
    [SerializeField] float hookGravityPower = 0.005f;
    [SerializeField] float hookProgressDegredationPower = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Fish();
        Hook();
    }

    void Fish()
    {
        fishTimer -= Time.deltaTime;
        if (fishTimer < 0f)
        {
            fishTimer = UnityEngine.Random.value * timeMultiplicator;

            fishDestination = UnityEngine.Random.value;
        }

        fishPosition = Mathf.SmoothDamp(fishPosition, fishDestination, ref fishSpeed, smoothMotion);
        fish.position = Vector3.Lerp(bottomPivot.position, topPivot.position, fishPosition);
    }

    void Hook()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            Debug.Log("Pressed");
            hookPullPower += hookPullPower * Time.deltaTime;
        }
        hookPullVelocity -= hookGravityPower * Time.deltaTime;

        hookPosition += hookPullVelocity;
        hookPosition = Mathf.Clamp(hookPosition, 0, 1);
        hook.position = Vector3.Lerp(bottomPivot.position, topPivot.position, hookPosition);

        //if(fishControls.InputActionMap.actionTriggered)
        //{

        //}
    }

    //Mouse.current.leftButton.wasPressedThisFrame  if(playerInput.FishMinigame.PlayerCatch.ReadValue<Mouse.current.leftButton.wasPressedThisFrame>)
}
