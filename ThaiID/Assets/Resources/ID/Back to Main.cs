using UnityEngine;

public class BacktoMain : MonoBehaviour
{
    public GameObject bigCardPage, tabbar; // Reference to the big card page
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        bigCardPage.SetActive(false); // Hide the big card page
        tabbar.SetActive(true); // Show the tab bar when the big card page is inactive
    }
}
