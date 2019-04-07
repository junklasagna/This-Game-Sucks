﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float offset;
    public GameObject projectile;
    public Transform shotpoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotz+offset);
        if (timeBtwShots <= 0)
         
        {

            if (Input.GetMouseButton(0))
            {
                Instantiate(projectile, shotpoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }    
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
