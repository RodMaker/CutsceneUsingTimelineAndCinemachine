using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private CanvasGroup _interactableUI;
    private bool _playerWithinRange;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _interactableUI.gameObject.SetActive(true);
            LeanTween.cancel(_interactableUI.gameObject);
            LeanTween.alphaCanvas(_interactableUI, 1, 1);
            _playerWithinRange = true;
        }
    }

    private void Update()
    {
        if (_playerWithinRange && Input.GetKeyUp(KeyCode.E))
        {
            Activate();
        }
    }

    public virtual void Activate()
    {
        _interactableUI.gameObject.SetActive(false);
    }

    public virtual void Deactivate()
    {

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _playerWithinRange = false;
            LeanTween.alphaCanvas(_interactableUI, 0, 1).setOnComplete(UIHide);
        }
    }

    private void UIHide()
    {
        
    }
}
