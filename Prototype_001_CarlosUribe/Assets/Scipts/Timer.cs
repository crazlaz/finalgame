﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //was going to add count down timer but not enough time.

    float currentTime = 0f;
    float startingTime = 10f; 

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;    
    }

    // Update is called once per frame
    void Update()
    {
       // currentTime -= 1 * Timer.deltaTime;
        print(currentTime);
        
    }
}
