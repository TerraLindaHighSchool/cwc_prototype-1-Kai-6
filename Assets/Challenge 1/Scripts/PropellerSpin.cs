using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
  private int RPM = 360/60;
  private float propSpeed = 2600;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, (propSpeed*RPM) * Time.deltaTime);
    }
}
