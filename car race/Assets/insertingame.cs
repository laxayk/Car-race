using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertingame : MonoBehaviour
{
    public GameObject cars;
    public GameObject enemy;
    public GameObject insertenemyat;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(cars, transform.position, transform.rotation);
        Instantiate(enemy, insertenemyat.transform.position, insertenemyat.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
