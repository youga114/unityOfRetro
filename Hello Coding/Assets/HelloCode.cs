﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        Debug.Log("0 번 학생의 점수: " + students[0]);
        Debug.Log("1 번 학생의 점수: " + students[1]);
        Debug.Log("2 번 학생의 점수: " + students[2]);
        Debug.Log("3 번 학생의 점수: " + students[3]);
        Debug.Log("4 번 학생의 점수: " + students[4]);
    }
}
