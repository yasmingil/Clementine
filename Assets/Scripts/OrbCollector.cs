using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float Scalar = 0.2f;

    private void OnTriggerEnter(Collider other)
    {
        Daylight D = other.GetComponent<Daylight>();
        //destroy(other);

        if (D == null) 
        {
            return;
        }

        else 
        {
           // D.Hours += 0.2f * Time.deltaTime;
        }
    }
}