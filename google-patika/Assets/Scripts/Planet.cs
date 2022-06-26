using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private Orbit[] moons;

    private void Awake()
    {
        foreach (Orbit moon in moons)
        {
            moon.orbitCenter = transform;
        }
    }
}
