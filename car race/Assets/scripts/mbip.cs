using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public enum controllerMode { keyboard = 1, touch = 2};
public class mbip : MonoBehaviour
{
   
    public controllerMode control;
    public  float accel;
    public float steer;
    public float brake;
    public Canvas ui;
    /*public EventSystem uiii;
    public Button accelb;
    public Button breakb;
    public Button revb;*/
    private CarController m_Car; // the car controller we want to use


    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<CarController>();
    }

    private void Update()
    {

        if (control == controllerMode.keyboard)
        {
            accel = Input.GetAxis("Vertical");
            steer = Input.GetAxis("Horizontal");
            brake = Input.GetAxis("Jump");
           // ui.SetActive(false);
            ui.enabled = false;
        }
        else
        {
          //  ui.SetActive(true);
            ui.enabled = true;
            steer = Input.acceleration.x;
        }
    }
    private void FixedUpdate()
    {
        m_Car.Move(steer, accel, accel, brake);
    }

    public void accelinput(float input)
    {
        accel = input;
        //accelb.GetComponent<EventTrigger>().OnPointerDown(new PointerEventData(uiii));
      
    } 
   
    public void brakeinput(float input)
    {
        brake = input;
    }
}