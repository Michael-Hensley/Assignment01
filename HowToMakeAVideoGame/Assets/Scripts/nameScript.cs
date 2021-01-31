using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameScript : MonoBehaviour
{
    public InputField playerName;
    public Text thePlayerName;
    
    // Update is called once per frame
    void Update()
    {
        thePlayerName.text = playerName.text;
    }
}
