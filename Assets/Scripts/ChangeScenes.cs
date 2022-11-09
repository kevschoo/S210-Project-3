using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    [SerializeField] bool PlayerCanEnter = false;
    [SerializeField] GameObject Text;
    [SerializeField] int SCENEID = 0;

    private void Start()
    {
        Text.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(true);
            PlayerCanEnter = true;
            Debug.Log("Player Enter");
            StartCoroutine(StartEnterCooldown());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(false);
            PlayerCanEnter = false;
            Debug.Log("Player Leave");
        }
    }

    IEnumerator StartEnterCooldown()
    {
        yield return new WaitForSeconds(5);
        if (PlayerCanEnter == true)
        {
            SceneManager.LoadScene(SCENEID);
        }
    }
}
