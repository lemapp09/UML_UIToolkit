using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UML3 : MonoBehaviour
{
        
    [SerializeField] private UIDocument _uiDocument;
    private VisualElement _root;
    private Button _homeButton;

    private void Start()
    {
        _root = _uiDocument.rootVisualElement;
        _homeButton = _root.Q<Button>("HomeButton");
        _homeButton.ClassListContains("HomeButton");
        _homeButton.RegisterCallback<ClickEvent>(OnHomeButtonClicked);
    }

    private void OnHomeButtonClicked(ClickEvent evt)
    {
        // Goto MainMneu
        SceneManager.LoadScene("MainScene");
    }

    private void OnDisable()
    {
        _homeButton.UnregisterCallback<ClickEvent>(OnHomeButtonClicked);
    }

   
}