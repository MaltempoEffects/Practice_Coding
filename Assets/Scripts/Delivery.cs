using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.1f;
    bool hasPickup;
    int points = 0;
    [SerializeField] Color32 regularColor = new Color32(0, 0, 0, 0);
    [SerializeField] Color32 pickupColor = new Color32(0, 0, 0, 0);

    MeshRenderer meshrenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        meshrenderer.material.color = regularColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Pickup" && !hasPickup)
        {
            hasPickup = true;
            meshrenderer.material.color = pickupColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if(other.tag == "Delivery" && hasPickup)
        {
            points++;
            meshrenderer.material.color = regularColor;
            hasPickup = false;
            Debug.Log("Score: " + points);
        }    
    }
}
