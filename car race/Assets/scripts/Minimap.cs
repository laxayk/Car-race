using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    private void Start()
    {
        if (GarageManager.i == 0) player = GameObject.FindGameObjectWithTag("Player1");
        if (GarageManager.i == 1) player = GameObject.FindGameObjectWithTag("Player2");
        if (GarageManager.i == 2) player = GameObject.FindGameObjectWithTag("Player3");
        if (GarageManager.i == 3) player = GameObject.FindGameObjectWithTag("Player4");
        if (GarageManager.i == 4) player = GameObject.FindGameObjectWithTag("Player5");
    }
    void LateUpdate()
    {
        Vector3 newPos = player.transform.position;
        newPos.y = transform.position.y;
        transform.position = newPos;
    }
}
