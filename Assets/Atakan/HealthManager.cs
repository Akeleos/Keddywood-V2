using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int Health;
     void Update()
    {
     if(Health <= 0)
         Gameover();
    }
     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("collectible"))
             Health++;
     }
     void Gameover()
     {
      
     }
}
