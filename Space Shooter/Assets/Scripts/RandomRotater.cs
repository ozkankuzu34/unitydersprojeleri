using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotater : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody physic;
    public int speed;
    void Start()
    {
        physic = GetComponent<Rigidbody>();

        physic.angularVelocity = Random.insideUnitSphere*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
