using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private float speed;

    public Transform orbitCenter;
    
    IEnumerator OrbitMovement(float speed, Transform orbitCenter)
    {
        transform.RotateAround(orbitCenter.position, Vector3.up, speed * Time.deltaTime);
        Debug.Log(transform + "   "  + orbitCenter + "   " + gameObject.ToString());
        yield return new WaitForFixedUpdate();
        StartCoroutine(OrbitMovement(speed, orbitCenter));
        
    }
    private void Start()
    {
        StartCoroutine(OrbitMovement(speed,orbitCenter));
    }
}
