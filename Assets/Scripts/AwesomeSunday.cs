using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwesomeSunday : MonoBehaviour
{
    private Vector3 initialPos;


    private void Start()
    {
        initialPos = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("obstacle"))
        {
            
            other.gameObject.SetActive(false);

            Debug.Log("x");

            StartCoroutine(Wait());

            other.gameObject.SetActive(true);



        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        transform.position = initialPos;

    }
}
