using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class FindThePlayer : MonoBehaviour
{
    public CinemachineVirtualCamera followCam;

    private void Start()
    {
        followCam = GameObject.Find("Cameras").GetComponent<CinemachineVirtualCamera>();

        followCam.LookAt = GameObject.FindGameObjectWithTag("Player").transform;
        followCam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }
}