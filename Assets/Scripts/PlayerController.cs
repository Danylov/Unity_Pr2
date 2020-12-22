using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll move the vehicle forward along Z axis
        // transform.Translate(0,0,1);
        transform.Translate(speed     * forwardInput    * Time.deltaTime * Vector3.forward);
        // transform.Translate(turnSpeed * horizontalInput * Time.deltaTime * Vector3.right);
        // We'll rotate the vehicle along Y axis
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
