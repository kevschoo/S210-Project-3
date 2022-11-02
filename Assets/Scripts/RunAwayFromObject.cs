using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class RunAwayFromObject : MonoBehaviour
{
    [SerializeField] Vector3 StartingPos;
    [SerializeField] Vector3 EndingPos;
    [SerializeField] bool MoveToTarget = false;
    private void Start()
    {
        StartingPos = this.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            MoveToTarget = true;
        }
    }

    private void Update()
    {
        if(MoveToTarget)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, EndingPos, Time.deltaTime);
            if (Vector3.Distance(EndingPos, this.transform.position) <= .01f)
            {MoveToTarget = false;}
        }
        else
        {
            this.transform.position = Vector3.Lerp(this.transform.position, StartingPos, Time.deltaTime);
        }

     }
}
