using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    [SerializeField] private FirstPersonMovement _firstPersonMovement;
    [SerializeField] private Jump _jump;
    [SerializeField] private Crouch _crouch;
    [SerializeField] private FirstPersonLook _firstPersonLook;
    [SerializeField] private GameObject _playerModel;
    [SerializeField] private Zoom _zoom;

    public GameObject FirstPersonCamera;        // Player FPS
    public GameObject CutsceneCamera;           // Cutscene with BRAIN
    public GameObject CutscenePlayerCamera;     // Cutscene from Player FPS (point of view)

    private void Awake()
    {
        Instance = this;
    }

    public void Activate()
    {
        _firstPersonMovement.enabled = true;
        _jump.enabled = true;
        _crouch.enabled = true;
        _firstPersonLook.enabled = true;
        _zoom.enabled = true;
        _playerModel.SetActive(true);
    }

    public void Deactivate()
    {
        _firstPersonMovement.enabled = false;
        _jump.enabled = false;
        _crouch.enabled = false;
        _firstPersonLook.enabled = false;
        _zoom.enabled = false;
        _playerModel.SetActive(false);
    }
}
