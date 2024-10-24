using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeAndTimeSpanMethods_ : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime futureDate;
    [SerializeField] private TimeSpan duration;
    [SerializeField] private double totalMinutes;

    // Start is called before the first frame update
    void Start()
    {
        now = DateTime.Now;
        Debug.Log("Time Now: "+now);
        futureDate = now.AddDays(11);
        Debug.Log("future Date: "+futureDate);

        duration = new TimeSpan(2, 15, 15);
        totalMinutes = duration.TotalMinutes;
        Debug.Log("Total Minutes: "+totalMinutes);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
