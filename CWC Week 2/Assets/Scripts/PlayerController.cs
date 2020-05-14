using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 15.5f;
    public float turnSpeed = 5.04f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the tank forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        //Moving and rotating right and left
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed *  Time.deltaTime );
    }
}
