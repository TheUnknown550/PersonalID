using UnityEngine;

public class PageController : MonoBehaviour
{
    public GameObject startPage, homePage;
    public PasswordText startPagePasswordText;

    void Start()
    {
        startPage.SetActive(true);
        homePage.SetActive(false);
    }

    void Update()
    {
        if (startPagePasswordText.full)
        {
            startPage.SetActive(false);
            homePage.SetActive(true);
        }
    }
    
}
