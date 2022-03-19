using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerSpawn : MonoBehaviour

{
    public GameObject player;
    public GameObject enemy;
    public GameObject lights;
    public vehiclist list;
    public GameObject startpos;
    public GameObject level1;
    public GameObject playergarage;
    public GameObject garage;
    public Animator menutoplay;
    public Animator playgayab;
    private CamMotor cam;
    public bool camtrigger = false;
    
    // Start is called before the first frame update
    void Awake()
    {
      //  Instantiate(list.vehicles[PlayerPrefs.GetInt("pointer")], startpos.transform.position, startpos.transform.rotation);



    }

    // Update is called once per frame
    void Update()
    {

       
    }
    public void play()
    {
        playgayab.SetTrigger("play");
        camtrigger = true;
        playergarage.SetActive(false);
        garage.SetActive(false);
        menutoplay.SetTrigger("play");
        level1.SetActive(true);
        new WaitForSeconds(3);
        //player.SetActive(true);
        enemy.SetActive(true);
        lights.SetActive(true);
    }
}
