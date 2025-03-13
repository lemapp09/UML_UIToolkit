using UnityEngine;
using UnityEngine.UIElements;

// Modern implementation for Unity 6+
[UxmlElement]
public partial class VolumeLabel : Label
{
    [UxmlAttribute("volume")]
    public int Volume 
    { 
        get => m_Volume;
        set
        {
            m_Volume = value;
            UpdateText();
        }
    }
    private int m_Volume = 0;

    public VolumeLabel()
    {
        // Initial text update
        UpdateText();
        
        // Update when attribute changes
        RegisterCallback<AttachToPanelEvent>(_ => UpdateText());
    }

    void UpdateText()
    {
        text = $"Volume: {Volume}%";
    }
}