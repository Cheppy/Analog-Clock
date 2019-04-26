using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] private Transform HoursArm;
    [SerializeField] private Transform MinutesArm;
    [SerializeField] private Transform SecondsArm;


    // Update is called once per frame
    void Update()
    {
        HoursArm.localRotation =
              Quaternion.Euler(0f, DateTime.Now.Hour * 30f, 0f);
        MinutesArm.localRotation =
            Quaternion.Euler(0f, DateTime.Now.Minute * 6f, 0f);
        SecondsArm.localRotation =
            Quaternion.Euler(0f, DateTime.Now.Second * 6f, 0f);



    }
}
