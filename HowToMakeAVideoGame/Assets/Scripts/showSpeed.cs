using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showSpeed : MonoBehaviour
{
    public Text speed;
    public float theSpeed = 2000f;
    void Update()
    {
        speed.text = theSpeed.ToString();
    }
    
    public void AdjustSpeed(float newSpeed)
    {
        //theSpeed = theSpeed * newSpeed;
        if(newSpeed == 1)
            {
                theSpeed = 1000f;
            }
            if(newSpeed == 2)
            {
                theSpeed = 2000f;
            }
            if(newSpeed == 3)
            {
                theSpeed = 3000f;
            }
    }
}
