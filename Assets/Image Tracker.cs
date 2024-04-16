using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTracker : MonoBehaviour
{
    private ARTrackedImageManager trackedImages;
    public GameObject[] ArPrefabs;
    public GameObject moon;

    List<GameObject> ARObjects = new List<GameObject>();


    void Awake()
    {
        trackedImages = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        trackedImages.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImages.trackedImagesChanged -= OnTrackedImagesChanged;
    }



    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        
        foreach (var trackedImage in eventArgs.added)
        {
            Debug.Log(trackedImage.referenceImage.name);
            
            foreach (var arPrefab in ArPrefabs)
            {
                
                if (trackedImage.referenceImage.name == arPrefab.name)
                {
                    var newPrefab = Instantiate(arPrefab, trackedImage.transform);
                    ARObjects.Add(newPrefab);

                    Debug.Log(arPrefab.name.ToString() + trackedImage.transform.position.ToString());

                     if (trackedImage.referenceImage.name == "earth")
                    {
                        var moonPrefab = Instantiate(moon, newPrefab.transform);
                        ARObjects.Add(moonPrefab);
                    }
                }

            }
        }

        
        foreach (var trackedImage in eventArgs.updated)
            
        {
            
            foreach (var gameObject in ARObjects)
            {
                if (gameObject.name == trackedImage.name)
                {
                    gameObject.SetActive(trackedImage.trackingState == TrackingState.Tracking);
                    
                }
            }
        }

    }
}

