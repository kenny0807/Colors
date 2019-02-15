﻿using UnityEngine;
using System.Collections;

public class RightOne : MonoBehaviour
{

    private GameObject mainCube;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    void OnMouseDown()
    {
        if (GetComponent<Renderer>().material.color == mainCube.GetComponent<Renderer>().material.color)
            mainCube.GetComponent<GameCntrl>().next = true;
        else
            mainCube.GetComponent<GameCntrl>().lose = true;
    }
}