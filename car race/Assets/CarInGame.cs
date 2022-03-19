using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CarInGame : MonoBehaviour
{
    public GameObject players;
    public Animator anim;


    void Start()
    {
        anim.SetTrigger("play");
        players = GameObject.FindGameObjectWithTag("PlayerMain");
        int x = players.transform.childCount;

        for (int i = 0; i < x; i++)
        {
            players.transform.GetChild(i).gameObject.SetActive(false);
            print(i);
            
        }

        players.transform.GetChild(GarageManager.i).gameObject.SetActive(true);
        print(GarageManager.i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void assignButtonsAccel(float input)
    {
        players.transform.GetChild(GarageManager.i).GetComponent<mbip>().accelinput(input);
    }
    public void assignButtonsbrake(float input)
    {
        players.transform.GetChild(GarageManager.i).GetComponent<mbip>().brakeinput(input);
    }
}
