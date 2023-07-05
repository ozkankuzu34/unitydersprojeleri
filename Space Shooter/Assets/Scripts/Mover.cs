using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody physic;

    [SerializeField] float speed;
    void Start()
    {
        physic = GetComponent<Rigidbody>();

        physic.velocity = transform.forward*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
