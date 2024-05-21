using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [SerializeField] float timeToAppear = 0.1f;
    [SerializeField] float rotateSpeed = 0.1f; 

    MeshRenderer meshrenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        meshrenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToAppear)
        {
            meshrenderer.enabled = true;
        }
        float rotate = rotateSpeed * Time.deltaTime;
        transform.Rotate(0f, rotate, 0f);
    }
}
