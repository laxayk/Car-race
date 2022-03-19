using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public static int x;
    // Start is called before the first frame update
    void Start()
    {
        x = gameObject.transform.childCount;
        for (int i = 1; i < x; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
