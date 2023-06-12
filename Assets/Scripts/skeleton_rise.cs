using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class skeleton_rise : MonoBehaviour
{
    [SerializeField] private List<GameObject> _skeletons;

    [SerializeField] private Button _nextSceneButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 

    private void OnMouseDown()
    {
        foreach (var skeleton in _skeletons)
        {
            skeleton.SetActive(true);
            _nextSceneButton.interactable = true;
        }
        
        
    }
}
