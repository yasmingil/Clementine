using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daylight : MonoBehaviour
{
    public float StartingDaylight = 100f;
    private const float Scalar = 0.2f;
    //private Hours = StartingDaylight;

    /* public float DaylightHours 
     {
         get {
             return Hours;
         } 
         set {
             Hours = Mathf.Clamp(value, 0f, StartingDaylight);

             if (Hours <= 0f) {
                 // destroy object idk
             }
         }
     }

     private float Hours = 100f;

     void Start() 
     {
         Hours = StartingDaylight;
     }

     void Update()
     {
         Hours -= Scalar * Time.deltaTime;
         // then change image somehow idk
     }
 }*/
}