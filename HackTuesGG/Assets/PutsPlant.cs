using JetBrains.Annotations;
using System;
using System.Collections;
using System.Dynamic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Animations;

public class PutsPlant : MonoBehaviour
{

    public GameObject Soil;

    public float xAxis;
    public float zAxis;
    public float yAxis;


    public void Start()
    {
        GetComponent<Transform>(); 
        Soil = GameObject.Find("razrovena_pochva");
        xAxis = Soil.transform.position.x;
        yAxis = Soil.transform.position.y;
        zAxis = Soil.transform.position.x;
        Debug.Log(xAxis);
        Debug.Log(yAxis);
        Debug.Log(zAxis);
        Soil.transform.localScale = new Vector3(0, 0, 0);
    }


    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Soil.transform.localScale = new Vector3(xAxis, yAxis, zAxis); 
        }
    }









}

