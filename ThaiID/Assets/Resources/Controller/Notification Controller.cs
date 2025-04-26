using UnityEngine;

public class NotificationController : MonoBehaviour
{
    public GameObject notificationPage, homePage, tabBar; // Page references
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        homePage.SetActive(true);
        notificationPage.SetActive(false);
        tabBar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openNotification(){
        // Initialize the pages
        homePage.SetActive(false);
        notificationPage.SetActive(true);
        tabBar.SetActive(false);
    }

    public void back(){
        // Switch to home page
        notificationPage.SetActive(false);
        homePage.SetActive(true);
        tabBar.SetActive(true);
    }
}
