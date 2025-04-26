using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateImages : MonoBehaviour
{
    public RawImage image1;
    public RawImage image2;
    public Button rotateButton;
    public float duration = 1.0f; // Rotation duration in seconds
    private bool isRotating = false;
    public GameObject bigCardPage, tabbar; // Reference to the big card page
    private float lastClickTime = 0f;
    private float doubleClickThreshold = 0.3f; // Time window for double-click

    void Start()
    {
        // rotateButton.onClick.AddListener(StartRotation);
        // bigCardPage.SetActive(false); // Ensure the big card page is inactive at the start
        tabbar.SetActive(true); // Ensure the tab bar is active at the start
    }

    public void OnClick()
    {
        if (Time.time - lastClickTime < doubleClickThreshold)
        {
            Debug.Log("Double Click Detected!");
            // Perform your double-click action here
            bigCardPage.SetActive(true); // Toggle the big card page visibility
            tabbar.SetActive(false); // Hide the tab bar when the big card page is active
            isRotating = false;
        }else{
            Debug.Log("Single Click Detected!");
            StartRotation();
            // Perform your single-click action here
        }
        lastClickTime = Time.time;
    }

    void StartRotation()
    {
        if (!isRotating)
        {
            StartCoroutine(RotateImage(image1));
            StartCoroutine(RotateImage(image2));
        }
    }

IEnumerator RotateImage(RawImage image)
{
    isRotating = true;
    float elapsedTime = 0f;

    // Get current Y rotation (in degrees)
    float currentY = image.transform.eulerAngles.y;

    // Snap current rotation to 0 or 180
    float startY = Mathf.Abs(currentY - 180f) < 90f ? 180f : 0f;
    float targetY = (startY == 0f) ? 180f : 0f;

    Quaternion startRotation = Quaternion.Euler(0, startY, 0);
    Quaternion targetRotation = Quaternion.Euler(0, targetY, 0);

    // Force snap to the normalized start rotation
    image.transform.rotation = startRotation;

    while (elapsedTime < duration)
    {
        image.transform.rotation = Quaternion.Lerp(startRotation, targetRotation, elapsedTime / duration);
        elapsedTime += Time.deltaTime;
        yield return null;
    }

    image.transform.rotation = targetRotation;
    isRotating = false;
}


}
