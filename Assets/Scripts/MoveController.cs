using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float boost = 0.1f;
    [SerializeField] float regularSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHor = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVer = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveHor, 0f, moveVer);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "SpeedUp")
        {
            moveSpeed = boost;
        }
        if(other.tag == "SlowDown")
        {
            moveSpeed = regularSpeed;
        }
    }
}
