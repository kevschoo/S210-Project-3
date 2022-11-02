using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]GameObject ObjectToOrbit;
    [SerializeField] float orbitspeed;
    // Update is called once per frame
    void Update()
    {
        if(ObjectToOrbit != null)
        {
            transform.RotateAround(ObjectToOrbit.transform.position, new Vector3(0, 1, 0), orbitspeed);
        }
    }
}
