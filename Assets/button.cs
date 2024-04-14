using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class button : MonoBehaviour
{
    public TMP_Text textbox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickbutton ()
    {
        textbox.text = "hello ";
    }
}
