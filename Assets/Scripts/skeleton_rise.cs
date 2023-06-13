using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class skeleton_rise : MonoBehaviour
{
    [SerializeField] private List<GameObject> _skeletons;

    [SerializeField] private Button _nextSceneButton;

    private void OnMouseDown()
    {
        foreach (var skeleton in _skeletons)
        {
            skeleton.SetActive(true);
            _nextSceneButton.interactable = true;
        }
        
        
    }
}
