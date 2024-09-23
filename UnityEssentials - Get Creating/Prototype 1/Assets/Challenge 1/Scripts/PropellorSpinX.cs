using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpinX : MonoBehaviour
{
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    
    {
        // spin propellor
        transform.Rotate(Vector3.forward);
        
    }
}
