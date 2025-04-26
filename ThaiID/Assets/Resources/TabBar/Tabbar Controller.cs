using UnityEngine;

public class TabbarController : MonoBehaviour
{
    public GameObject homePage, qrCodePage, tabBar, HistoryPage, DocumentPage, SettingsPage; // Page references
    public GameObject homePageTick, historyTick, settingsTick, documentTick;


    void Start()
    {
        // Initialize the pages
        homePage.SetActive(true);
        qrCodePage.SetActive(false);
        tabBar.SetActive(true);
        HistoryPage.SetActive(false);
        DocumentPage.SetActive(false);
        SettingsPage.SetActive(false);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(true);
        historyTick.SetActive(false);
        settingsTick.SetActive(false);
        documentTick.SetActive(false);
    }

    public void openSettingsPage()
    {
        // Initialize the pages
        homePage.SetActive(false);
        qrCodePage.SetActive(false);
        tabBar.SetActive(true);
        HistoryPage.SetActive(false);
        DocumentPage.SetActive(false);
        SettingsPage.SetActive(true);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(false);
        historyTick.SetActive(false);
        settingsTick.SetActive(true);
        documentTick.SetActive(false);
    }

    public void openDocument(){
        // Initialize the pages
        homePage.SetActive(false);
        qrCodePage.SetActive(false);
        tabBar.SetActive(true);
        HistoryPage.SetActive(false);
        DocumentPage.SetActive(true);
        SettingsPage.SetActive(false);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(false);
        historyTick.SetActive(false);
        settingsTick.SetActive(false);
        documentTick.SetActive(true);
    }

    public void openHomePage()
    {
        // Initialize the pages
        homePage.SetActive(true);
        qrCodePage.SetActive(false);
        tabBar.SetActive(true);
        HistoryPage.SetActive(false);
        DocumentPage.SetActive(false);
        SettingsPage.SetActive(false);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(true);
        historyTick.SetActive(false);
        settingsTick.SetActive(false);
        documentTick.SetActive(false);
    }

    public void openHistoryPage()
    {
        // Initialize the pages
        homePage.SetActive(false);
        qrCodePage.SetActive(false);
        tabBar.SetActive(true);
        HistoryPage.SetActive(true);
        DocumentPage.SetActive(false);
        SettingsPage.SetActive(false);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(false);
        historyTick.SetActive(true);
        settingsTick.SetActive(false);
        documentTick.SetActive(false);
    }

    public void openQrCodePage()
    {
        // Initialize the pages
        homePage.SetActive(false);
        qrCodePage.SetActive(true);
        tabBar.SetActive(false);
        HistoryPage.SetActive(false);
        DocumentPage.SetActive(false);
        SettingsPage.SetActive(false);
        // Initialize the ticks
        // Set the initial state of the ticks
        homePageTick.SetActive(false);
        historyTick.SetActive(false);
        settingsTick.SetActive(false);
        documentTick.SetActive(false);
    }

}
