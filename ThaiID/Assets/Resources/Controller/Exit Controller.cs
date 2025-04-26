using UnityEngine;

public class ExitController : MonoBehaviour
{
    public GameObject exitPage; // Page references
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        exitPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openExitPage(){
        // Initialize the pages
        exitPage.SetActive(true);
    }

    public void closeExitPage(){
        // Switch to home page
        exitPage.SetActive(false);
    }

    public void exitApp(){
        // Exit the application
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in editor
        #endif
    }
}
