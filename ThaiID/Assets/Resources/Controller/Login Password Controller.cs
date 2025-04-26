using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoginPasswordController : MonoBehaviour
{
    public PasswordText sprite1, sprite2, sprite3, sprite4, sprite5, sprite6, sprite7, sprite8;

    public void Start()
    {

    }

    public void deleteInput(){
        if (sprite8.state){
            sprite8.state = false;
            sprite8.full = false;
        }
        else if (sprite7.state){
            sprite7.state = false;
        }
        else if (sprite6.state){
            sprite6.state = false;
        }
        else if (sprite5.state){
            sprite5.state = false;
        }
        else if (sprite4.state){
            sprite4.state = false;
        }
        else if (sprite3.state){
            sprite3.state = false;
        }
        else if (sprite2.state){
            sprite2.state = false;
        }
        else if (sprite1.state){
            sprite1.state = false;
        }
    }

    public void OnClick()
    {
        if (!sprite1.state)
        {
            sprite1.state = true;
            
        }
        else if (!sprite2.state)
        {
            sprite2.state = true;
            
        }
        else if (!sprite3.state)
        {
            sprite3.state = true;
            
        }
        else if (!sprite4.state)
        {
            sprite4.state = true;
            
        }
        else if (!sprite5.state)
        {
            sprite5.state = true;
            
        }
        else if (!sprite6.state)
        {
            sprite6.state = true;
            
        }
        else if (!sprite7.state)
        {
            sprite7.state = true;
            
        }
        else if (!sprite8.state)
        {
            sprite8.state = true;
            sprite8.full = true;
        }
        
    }



}


