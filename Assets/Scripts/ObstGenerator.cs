using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstGenerator : MonoBehaviour
{
    public float maxTime = 1;
    private float startTime = 0;
    public GameObject obstacle;
    public float height;


    void Start()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstacle, 10);
    }


    void Update()
    {
        if (startTime > maxTime)
        {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);
            Destroy(obstacle, 10);
            startTime = 0;
        }
        else
        {
            startTime += Time.deltaTime;
        }
    }
}
