using System;
using UnityEngine;
using UnityEngine.UIElements;

public class UIToolkit5 : MonoBehaviour
{
        
    [SerializeField] private UIDocument _uiDocument;
    private VisualElement _root;
    private VolumeLabel _volumeLabel;

    private void Start()
    {
        _root = _uiDocument.rootVisualElement;
        _volumeLabel = _root.Q<VolumeLabel>("VolumeLabel");
        
        _volumeLabel.Volume = 90; // Text auto-updates to "Volume: 90%"
    }
}