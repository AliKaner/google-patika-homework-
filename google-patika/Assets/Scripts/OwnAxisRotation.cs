using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnAxisRotation : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    
    IEnumerator SelfRotation(Rigidbody rb,float speed)
    {
        rb.AddTorque(transform.up*speed);
        yield return new WaitForFixedUpdate();
        StartCoroutine(SelfRotation(rb,speed));
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        StartCoroutine(SelfRotation(rb, speed));
    }

    
}
