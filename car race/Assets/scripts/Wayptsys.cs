using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityStandardAssets.Vehicles.Car;

public class Wayptsys : MonoBehaviour
{
    public GameObject marker;

    /*    public GameObject Mark01;

        public GameObject Mark02;

        public GameObject Mark03;
        public GameObject Mark04;
        public GameObject Mark05;
        public GameObject Mark06;
        public GameObject Mark07;
        public GameObject Mark08;
        public GameObject Mark09;
        public GameObject Mark10;
        public GameObject Mark11;
        public GameObject Mark12;*/
    public GameObject[] Mark;
    public CarAIControl carai;


    public int marktracker;
    public int marknum ;

    /*public GameObject Waypoint;*/


    // Update is called once per frame
    void Update()
    {
        /* if (marktracker == 0)
         {
             marker.transform.position = Mark01.transform.position;
             marker.transform.rotation = Mark01.transform.rotation;
         }
         if (marktracker == 1)
         {
             marker.transform.position = Mark02.transform.position;
             marker.transform.rotation = Mark02.transform.rotation;
         }
         if (marktracker == 2)
         {
             marker.transform.position = Mark03.transform.position;
             marker.transform.rotation = Mark03.transform.rotation;
         }
         if (marktracker == 3)
         {
             marker.transform.position = Mark04.transform.position;
             marker.transform.rotation = Mark04.transform.rotation;
         }
         if (marktracker == 4)
         {
             marker.transform.position = Mark05.transform.position;
             marker.transform.rotation = Mark05.transform.rotation;
         }
         if (marktracker == 5)
         {
             marker.transform.position = Mark06.transform.position;
             marker.transform.rotation = Mark06.transform.rotation;
         }
         if (marktracker == 6)
         {
             marker.transform.position = Mark07.transform.position;
             marker.transform.rotation = Mark07.transform.rotation;
         }
         if (marktracker == 7)
         {
             marker.transform.position = Mark08.transform.position;
             marker.transform.rotation = Mark08.transform.rotation;
         }
         if (marktracker == 8)
         {
             marker.transform.position = Mark09.transform.position;
             marker.transform.rotation = Mark09.transform.rotation;
         }
         if (marktracker == 9)
         {
             marker.transform.position = Mark10.transform.position;
             marker.transform.rotation = Mark10.transform.rotation;
         }
         if (marktracker == 10)
         {
             marker.transform.position = Mark11.transform.position;
             marker.transform.rotation = Mark11.transform.rotation;
         }
         if (marktracker == 11)
         {
             marker.transform.position = Mark12.transform.position;
             marker.transform.rotation = Mark12.transform.rotation;
         }
         if (marktracker == 0)
         {
             marker.transform.position = Mark01.transform.position;
             marker.transform.rotation = Mark01.transform.rotation;
         }*/
        if (marktracker == marknum)
        {
           
            marker.transform.position = Mark[marknum].transform.position;
            marker.transform.rotation = Mark[marknum].transform.rotation;
            marknum++;
        }

    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Enemy1")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
            if(marktracker == 31)
            {
                // marktracker = 0;
                carai.m_Driving = false;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true; 
        }
    }
}
