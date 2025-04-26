using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoubleClickButtonBigMain : MonoBehaviour
{
    public Button button;

    public GameObject BigID;
    
    public RawImage image1;
    public RawImage image2;
    public float duration = 1.0f; // Rotation duration in seconds
    private bool isRotating = false;

    private float lastClickTime = 0f;
    private float doubleClickThreshold = 0.3f; // Time window for double-click

    void Start()
    {
        BigID.SetActive(false);
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Single Click Detected!");
        StartRotation();
        // Perform your single-click action here
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
        Quaternion startRotation = image.transform.rotation;
        Quaternion targetRotation = startRotation * Quaternion.Euler(0, 180, 0);
        
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
