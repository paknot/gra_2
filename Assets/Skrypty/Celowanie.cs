using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celowanie : MonoBehaviour
{

    public Vector3 aimDownSight;
    public Vector3 hipFire;
  
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition,aimDownSight, 10 * Time.deltaTime);
        }
        if(Input.GetMouseButtonUp(1))
        {
            transform.localPosition = hipFire;
        }
    }
}
