using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoubleClickButtonBig : MonoBehaviour
{
    public Button button;

    public GameObject smallID, BigID;
    
    public RawImage image1;
    public RawImage image2;
    public float duration = 1.0f; // Rotation duration in seconds
    private bool isRotating = false;

    private float lastClickTime = 0f;
    private float doubleClickThreshold = 0.3f; // Time window for double-click

    void Start()
    {
        smallID.SetActive(true);
        BigID.SetActive(false);
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (Time.time - lastClickTime < doubleClickThreshold)
        {
            Debug.Log("Double Click Detected!");
            // Perform your double-click action here
            if(!BigID.activeSelf){
                smallID.SetActive(false);
                BigID.SetActive(true);
            }else{
                smallID.SetActive(true);
                BigID.SetActive(false);
            }
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
