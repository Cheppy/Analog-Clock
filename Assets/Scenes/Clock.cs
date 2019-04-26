using System;
using UnityEngine;

public class Clock : MonoBehaviour {

	const float
		degreesPerHour = 30f,
		degreesPerMinute = 6f,
		degreesPerSecond = 6f;

    [SerializeField] private Transform transform_HoursArm;
    [SerializeField] private Transform transform_MinutesArm;
    [SerializeField] private Transform transform_SecondsArm;



    void UpdateContinuous()
    {


    }
}