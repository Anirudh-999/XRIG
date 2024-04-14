using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UIandsound : MonoBehaviour
{
    public TMP_Text infobox;
    public AudioClip marsclip1;
    public AudioClip marsclip2;
    public AudioClip marsclip3;
    public AudioClip earthclip1;
    public AudioClip earthclip2;
    public AudioClip earthclip3;

    AudioSource audio;

    string UIstate = "void";
    int infoid = 1;

    string marstext1 = "The planet you are currently looking at is mars ";
    string marstext2 = "It is also known as the red planet ";
    string marstext3 = "It is smaller than Earth with a diameter of 6790Km almost half compared to Earth";

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "mars")
                {
                    UIstate = "Mars";
                    infoid = 1;
                    infobox.text = marstext1;
                    audio.PlayOneShot(marsclip1, 1f);

                }

                if (hit.transform.tag == "info")
                {
                    Destroy(hit.transform.gameObject);
                    infobox.text = "select a game object";
                    UIstate = "void";
                }

                if (hit.transform.tag == "earth")
                {
                    UIstate = "earth";
                    infoid = 1;
                    infobox.text = marstext1;
                    audio.PlayOneShot(earthclip1, 1f);

                }



            }
        }
    }

    public void nextButton()
    {
        if (audio.isPlaying)
        {
            audio.Stop();
        }

        if (UIstate == "Mars")
        {
            switch (infoid)
            {
                case (1):
                    infoid = 2;
                    infobox.text = marstext2;
                    audio.PlayOneShot(marsclip2, 1f);
                    break;
                case (2):
                    infoid = 3;
                    infobox.text = marstext3;
                    audio.PlayOneShot(marsclip3, 1f);
                    break;
                default:
                    break;
            }
        }

        if (UIstate == "Earth")
        {

        }
    }
}
    
