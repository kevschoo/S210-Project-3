using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{

    [SerializeField] GameObject ObjectToLookAt;

    // Update is called once per frame
    void LateUpdate()
    {
        if(ObjectToLookAt != null)
        {
            this.gameObject.transform.LookAt(ObjectToLookAt.transform);
        }
    }
}
