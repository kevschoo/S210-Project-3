using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFollow : MonoBehaviour
{
    [SerializeField]GameObject gameObjecttofollow;


    private void Update()
    {
        this.gameObject.transform.position = gameObjecttofollow.transform.position;
    }
}
