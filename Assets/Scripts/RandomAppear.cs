using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAppear : MonoBehaviour
{
    bool CanAppear = false;
    bool IsVisible = true;
    [SerializeField]  float timer = 10f;
    [SerializeField] GameObject Particlesystem;
    [SerializeField] GameObject MainBody;

    void Start()
    {
        StartCoroutine(StartAppearance());

        Particlesystem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator StartAppearance()
    {
        CanAppear = false;
        yield return new WaitForSeconds(timer);
        if (IsVisible == false)
        {

            Particlesystem.SetActive(false);
            IsVisible = true;
            MainBody.SetActive(IsVisible);
        }
        else
        {
            Particlesystem.SetActive(true);
            IsVisible = false;
            MainBody.SetActive(IsVisible);
        }
        StartCoroutine(StartAppearance());
    }
}
