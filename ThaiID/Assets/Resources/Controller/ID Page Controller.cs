using UnityEngine;

public class IDPageController : MonoBehaviour
{
    public GameObject BigID,SmallID; // Page references
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeBigID(){
        // Initialize the pages
        BigID.SetActive(false);
        SmallID.SetActive(true);
    }
}
