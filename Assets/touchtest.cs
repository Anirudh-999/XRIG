using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class touchtest : MonoBehaviour
{

    public GameObject marspopup;
    public GameObject earthpopup;
    public TMP_Text textbox;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("primary button");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if ( Physics.Raycast(ray, out hit, 100)) 
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name+":"+hit.transform.tag);

                if(hit.transform.tag == "mars")
                {
                    /*
                    Vector3 pos = (hit.point);
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(marspopup , pos , transform.rotation);
                    */

                    textbox.text = "info will come here";

                }

                if (hit.transform.tag == "earth")
                {
                    /*
                    Vector3 pos = (hit.point);
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(earthpopup, pos, transform.rotation);
                    */

                    textbox.text = "info will come here";

                }

                if (hit.transform.tag == "info")
                {
                    Destroy(hit.transform.gameObject);
                }

            }
        }
    }
}
