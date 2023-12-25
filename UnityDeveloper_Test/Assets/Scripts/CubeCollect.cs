using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollect : MonoBehaviour
{
    private int cubeCollected = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "CubeCollected")
        {
            Destroy(other.gameObject);
            cubeCollected= cubeCollected+100;
            Debug.Log(cubeCollected);
        }
    }
}
