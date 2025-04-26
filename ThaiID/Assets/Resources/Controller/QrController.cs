using UnityEngine;
using UnityEngine.UI;

public class QrController : MonoBehaviour
{

    public GameObject qrCodePage, homePage, tabBar; // Page references
    public GameObject homePageTick;

    public void back(){
        // Switch to home page
        qrCodePage.SetActive(false);
        homePage.SetActive(true);
        tabBar.SetActive(true);
        homePageTick.SetActive(true);
        webcamTexture.Stop();
    }

    private WebCamTexture webcamTexture;
    public RawImage cameraDisplay;
    public AspectRatioFitter aspectFitter;

    void Start()
    {
        // Get available cameras
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0)
        {
            Debug.LogError("No camera found!");
            return;
        }

        // Use the first camera (modify if you need rear/front camera selection)
        webcamTexture = new WebCamTexture(devices[0].name, 1920, 1080);
        cameraDisplay.texture = webcamTexture;
        webcamTexture.Play();

        // Wait a bit before adjusting for rotation & aspect ratio
        StartCoroutine(AdjustCameraSettings());
    }

    private System.Collections.IEnumerator AdjustCameraSettings()
    {
        yield return new WaitForSeconds(0.5f); // Wait for camera to start

        if (webcamTexture == null)
            yield break;

        // 🔹 **Fix Aspect Ratio**
        float aspectRatio = (float)webcamTexture.width / webcamTexture.height;
        aspectFitter.aspectRatio = aspectRatio;

        // 🔹 **Fix Rotation (Some Cameras Report Wrong Values)**
        int rotation = webcamTexture.videoRotationAngle;
        cameraDisplay.rectTransform.localEulerAngles = new Vector3(0, 0, -rotation);

        // 🔹 **Fix Mirroring (Some Front Cameras Are Mirrored)**
        bool isMirrored = webcamTexture.videoVerticallyMirrored;
        cameraDisplay.uvRect = isMirrored ? new Rect(1, 0, -1, 1) : new Rect(0, 0, 1, 1);
    }

    void OnDestroy()
    {
        if (webcamTexture != null)
        {
            webcamTexture.Stop();
        }
    }
}
