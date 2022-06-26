using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private Orbit[] planets;

    private void Awake()
    {
        foreach (Orbit moon in planets)
        {
            moon.orbitCenter = transform;
        }
    }
}
