using UnityEngine;

public class DocumentController : MonoBehaviour
{
    public GameObject Tabbar, DocumentPage, SubPage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Tabbar.SetActive(true);
        DocumentPage.SetActive(true);
        SubPage.SetActive(false);
    }

    public void openSubPage()
    {
        // Initialize the pages
        Tabbar.SetActive(false);
        DocumentPage.SetActive(false);
        SubPage.SetActive(true);
    }
    
    public void closeSubPage()
    {
        // Switch to home page
        SubPage.SetActive(false);
        DocumentPage.SetActive(true);
        Tabbar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
