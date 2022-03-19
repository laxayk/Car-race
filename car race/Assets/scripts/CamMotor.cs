using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamMotor : MonoBehaviour
{
   
    [Tooltip("Vehicle to look at.")]
    public GameObject car;
    
   

  
    [Tooltip("X rotation angle of the camera, relatively to the vehicle.")]
    public float lookXAngle;


    [Tooltip("Position the camera tries to reach progressively, relatively to the vehicle.")]
    public Vector3 carRelativeTargetPosition;

   
    [Tooltip("Duration, in seconds, it would take the camera to reach its target position if the vehicle immediately stopped.")]
    public float repositioningDuration;
   
    
   

    private void Start()
    {
        if(GarageManager.i == 0) car = GameObject.FindGameObjectWithTag("Player1");
        if (GarageManager.i == 1) car = GameObject.FindGameObjectWithTag("Player2");
        if (GarageManager.i == 2) car = GameObject.FindGameObjectWithTag("Player3");
        if (GarageManager.i == 3) car = GameObject.FindGameObjectWithTag("Player4");
        if (GarageManager.i == 4) car = GameObject.FindGameObjectWithTag("Player5");

    }

    void FixedUpdate()
    {
       
      
        
        Vector3 targetPosition = car.transform.TransformPoint(carRelativeTargetPosition);

        Quaternion targetRotation = car.transform.rotation * Quaternion.Euler(lookXAngle, 0f, 0f);
        float progress = Mathf.Min(Time.deltaTime / repositioningDuration, 1.0f);
        transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition, progress);
        transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, targetRotation, progress);
        
        
    }
}
