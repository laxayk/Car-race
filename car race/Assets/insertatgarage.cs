using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertatgarage : MonoBehaviour
{
    public GameObject cars;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(cars, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
