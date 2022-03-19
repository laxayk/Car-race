using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GarageManager : MonoBehaviour
{
    public GameObject player;
    public static int i = 0;
    public static int j = 0;
    public static int selected;
    public GameObject[] maps;
    public int count = 0;



    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
            
    }

    
    // Start is called before the first frame update
   public void right()
    {
        if (count == 1)
        {
            if (j >= 1) return;
            maps[j].SetActive(false);
            j++;
            maps[j].SetActive(true);
            return;
        }
        if (i >= menu.x - 1) return;
        

        player.transform.GetChild(i).gameObject.SetActive(false);
        i++;
        player.transform.GetChild(i).gameObject.SetActive(true);
       

    }
    public void left()
    {
        if (count == 1)
        {
            if (j <= 0) return;
            maps[j].SetActive(false);
            j--;
            maps[j].SetActive(true);
            return;
        }
        if (i <= 0) return;
       
        player.transform.GetChild(i).gameObject.SetActive(false);
        i--;
        player.transform.GetChild(i).gameObject.SetActive(true);
       


    }

    public void select()
    {
        //SceneManager.LoadScene(1);
        Destroy(player);
        maps[j].SetActive(true);
        count++;
        if (count == 2)
        {
            if (maps[0].active == true)
            {
                SceneManager.LoadScene(1);
            }
            if (maps[1].active == true)
            {
                SceneManager.LoadScene(2);
            }
        }

    }
    
    public void levelSelect()
    {
        
            

    }
}
