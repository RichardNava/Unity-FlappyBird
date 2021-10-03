using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float velocity = 1;

    void Start()
    {
        
    }
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
