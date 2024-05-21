using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.1f;
    bool hasPickup;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("Pick!");
        }
        if(other.tag == "Delivery" && hasPickup)
        {
            hasPickup = false;
            Debug.Log("Delivered!");
        }    
    }
}
