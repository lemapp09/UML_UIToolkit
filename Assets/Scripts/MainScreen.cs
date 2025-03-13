using System;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    private VisualElement _root;

    private VisualElement _umlRow1, _umlRow2,_umlRow3, _uiToolkitRow1, _uiToolkitRow2,
        _uiToolkitRow3, _uiToolkitRow4, _uiToolkitRow5;

    private void Start()
    {
        _root = _uiDocument.rootVisualElement;
        _umlRow1 = _root.Q<VisualElement>("UMLRow1");
        _umlRow2 = _root.Q<VisualElement>("UMLRow2");
        _umlRow3 = _root.Q<VisualElement>("UMLRow3");
        _uiToolkitRow1 = _root.Q<VisualElement>("UIToolkitRow1");
        _uiToolkitRow2 = _root.Q<VisualElement>("UIToolkitRow2");
        _uiToolkitRow3 = _root.Q<VisualElement>("UIToolkitRow3");
        _uiToolkitRow4 = _root.Q<VisualElement>("UIToolkitRow4");
        _uiToolkitRow5 = _root.Q<VisualElement>("UIToolkitRow5");
        
        // Make rows clickable
        _umlRow1.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML1"));
        _umlRow2.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML2"));
        _umlRow3.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML3"));
        _uiToolkitRow1.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit1"));
        _uiToolkitRow2.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit2"));
        _uiToolkitRow3.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit3"));
        _uiToolkitRow4.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit4"));
        _uiToolkitRow5.RegisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit5"));
    }

    private EventCallback<ClickEvent> OnHome()
    {
        return evt => SceneManager.LoadScene("MainScene");
    }

    private EventCallback<ClickEvent> OnQuit()
    {
        Debug.Log("Quit");
        // Need to quit both standalone app and when in Editor Mode
        return evt =>
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        };
    }

    private void OnDisable()
    {
        _umlRow1.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML1"), TrickleDown.TrickleDown);
        _umlRow2.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML2"));
        _umlRow3.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UML3"));
        _uiToolkitRow1.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit1"));
        _uiToolkitRow2.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit2"));
        _uiToolkitRow3.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit3"));
        _uiToolkitRow4.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit4"));
        _uiToolkitRow5.UnregisterCallback<ClickEvent>(evt => SceneManager.LoadScene("UIToolkit5"));
    }
}
