using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class ARUImodified : MonoBehaviour
{

    public List<string> infoText = new List<string>();
    public List<AudioClip> infoAudio = new List<AudioClip>();
    public List<Texture2D> imageList = new List<Texture2D>();

    public Canvas canvas;
    public TMP_Text infoBox;



    AudioSource audio;

    int infoPointer = -1;

    int maxpointer = -1;

    int minpointer = -1;

    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        canvas.enabled = true;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {
                if (hit.transform.tag == "mercury")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 0;
                    maxpointer = 2;
                    minpointer = 0;
                    displayAndPlayInfo();
                   
                }
              


                if (hit.transform.tag == "venus")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 3;
                    maxpointer = 5;
                    minpointer = 3;
                    displayAndPlayInfo();

                   
                }

                if (hit.transform.tag == "earth")
                {
                    //do something!
                   // displayCanvas();
                    infoPointer = 6;
                    maxpointer = 8;
                    minpointer = 6;
                    displayAndPlayInfo();


                }

                if (hit.transform.tag == "mars")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 9;
                    maxpointer = 11;
                    minpointer = 9;
                    displayAndPlayInfo();


                }

                if (hit.transform.tag == "jupiter")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 12;
                    maxpointer = 14;
                    minpointer = 12;
                    displayAndPlayInfo();


                }

                if (hit.transform.tag == "saturn")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 15;
                    maxpointer = 17;
                    minpointer = 15;
                    displayAndPlayInfo();


                }

                if (hit.transform.tag == "uranus")
                {
                    //do something!
                    //displayCanvas();
                    infoPointer = 18;
                    maxpointer = 20;
                    minpointer = 18;

                    displayAndPlayInfo();


                }

                if(hit.transform.tag == "neptune")
                {
                    //displayCanvas();
                    infoPointer = 21;
                    maxpointer = 23;
                    minpointer = 21;

                    displayAndPlayInfo();
                }
            }
            

        }
    }

    void displayAndPlayInfo()
    {
        infoBox.text = infoText[infoPointer];
        if (audio.isPlaying) { audio.Stop(); }
        audio.PlayOneShot(infoAudio[infoPointer], 1f);
        
    }

    public void nextInfo()
    {
        if(infoPointer < maxpointer )
        {
            
            infoPointer += 1;
            displayAndPlayInfo();
            
        }
        
       
    }

    public void lastInfo()
    {
        if (infoPointer > minpointer)
        {
            
            infoPointer -= 1;
            displayAndPlayInfo();
            
        }
    }

    /*
    public void displayCanvas()
    {
        canvas.enabled = true;

    }

    public void hideCanvas()
    {
        canvas.enabled = false;
    }
    */



}
