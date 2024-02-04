using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.10f;
    public bool doSpin = true, doMotion=false;
    // Start is called before the first frame update
    /* void Start()
     {
         don't really need it for this script       
     }*/

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            // rotate around the up axis of the game object
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime); // Vector3 means 3d vector
        }

        if (doMotion)
        {
            // move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
    }
}
