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
    public Transform objecttoscale;

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
                    open();
                    infoPointer = 0;
                    maxpointer = 2;
                    minpointer = 0;
                    displayAndPlayInfo();
             
                }
              


                if (hit.transform.tag == "venus")
                {
                    open();
                    infoPointer = 3;
                    maxpointer = 5;
                    minpointer = 3;
                    displayAndPlayInfo();

                   
                }

                if (hit.transform.tag == "earth")
                {
                    open();
                    infoPointer = 6;
                    maxpointer = 8;
                    minpointer = 6;
                    displayAndPlayInfo();

                     
                }

                if (hit.transform.tag == "mars")
                {
                    open();
                    infoPointer = 9;
                    maxpointer = 11;
                    minpointer = 9;
                    displayAndPlayInfo();

                }

                if (hit.transform.tag == "jupiter")
                {
                    open();
                    infoPointer = 12;
                    maxpointer = 14;
                    minpointer = 12;
                    displayAndPlayInfo();

                }

                if (hit.transform.tag == "saturn")
                {
                    open();
                    infoPointer = 15;
                    maxpointer = 17;
                    minpointer = 15;
                    displayAndPlayInfo();

                }

                if (hit.transform.tag == "uranus")
                {
                    open();
                    infoPointer = 18;
                    maxpointer = 20;
                    minpointer = 18;

                    displayAndPlayInfo();

                }

                if(hit.transform.tag == "neptune")
                {
                    open();
                    infoPointer = 21;
                    maxpointer = 23;
                    minpointer = 21;

                    displayAndPlayInfo();
                }

                if(hit.transform.tag == "moon")
                {
                    open();
                    infoPointer = 24;
                    maxpointer = 26;
                    minpointer = 24;

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

    public void close()
    {
        canvas.enabled = false;
        if(audio.isPlaying) { audio.Stop(); }
    }
    public void open()
    {
        canvas.enabled = true;
    }

    public void lastInfo()
    {
        if (infoPointer > minpointer)
        {
            
            infoPointer -= 1;
            displayAndPlayInfo();
            
        }
    }

    public void home()
    {
        if(audio.isPlaying) { audio.Stop();};
        infoBox.text = "WELCOME TO AR PLANET EXPERIENCE";

    }
    /*
    public void displayCanvas()
    {
        canvas.enabled = true;

    }
    */

    /*
    public void hideCanvas()
    {
        canvas.enabled = false;
    }
    */
    



}
