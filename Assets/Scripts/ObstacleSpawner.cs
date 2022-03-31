using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
  public int num = 20;
  public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < num+1; i++) {
          GameObject obs = Object.Instantiate(obstacle, new Vector3(Random.Range(-8,8), 0, map(i, 0, num, 25, 180)), Quaternion.Euler(0,180,0));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


float map (float value, float from1, float to1, float from2, float to2) {
    return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
}
}
