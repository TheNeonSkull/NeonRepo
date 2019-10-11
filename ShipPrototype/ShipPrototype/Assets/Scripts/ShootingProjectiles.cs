﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingProjectiles : MonoBehaviour
{
   public float damage = 10f;
   public float distance = 100f;
   public Camera ShootersCam;

    // Update is called once per frame
    void Update()
    {
     if (Input.GetButtonDown("Fire1")){
         Shoot();
     }   
    }
    void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(ShootersCam.transform.position, ShootersCam.transform.forward, out hit, distance)){
Debug.Log(hit);
            }

        }
}
