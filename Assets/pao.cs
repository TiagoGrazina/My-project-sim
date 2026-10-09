using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pao : MonoBehaviour
{
    public Rigidbody variavel;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
       variavel.linearVelocity = new Vector3(0, 0, 10f); 
    }
}