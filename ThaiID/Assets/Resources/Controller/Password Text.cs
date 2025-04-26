using UnityEngine;
using UnityEngine.UI;

public class PasswordText : MonoBehaviour
{
    public Image image;
    public Sprite turnOn;
    public Sprite turnOff;

    public bool state = false;
    public bool full = false;

    void Start()
    {
        state = false;
        updateState();
    }

    void Update(){
        updateState();
    }

    public void updateState()
    {
        if (state)
        {
            image.sprite = turnOn;
        }
        else
        {
            image.sprite = turnOff;
        }
    }



}
