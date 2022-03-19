using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGarage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Vector3.zero);
        transform.RotateAround(Vector3.zero, Vector3.up, 30 * Time.deltaTime);
    }
}
