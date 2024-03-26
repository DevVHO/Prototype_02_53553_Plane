using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float constantspeed = 40.0f;
    private Vector3 forceup = new Vector3(0.2f,0,0);
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        Physics.gravity = Vector3.zero;


        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward  * Time.deltaTime * constantspeed);
        transform.Rotate(forceup * verticalInput);
    }
}
