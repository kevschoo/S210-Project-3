using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPath : MonoBehaviour
{

    [SerializeField] List<Transform> Points = new List<Transform>();
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Points.Count > 1)
        {
            
            if(index > Points.Count - 1)
            {
                index = 0;
            }
            if(Vector3.Distance(this.transform.position, Points[index].position) < .01f)
            {
                index++;
            }
            if(index < Points.Count)
            {
                this.transform.position = Vector3.Lerp(this.transform.position, Points[index].position, Time.deltaTime);
            }

        }
    }
}
