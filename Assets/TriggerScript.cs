using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {     
        Destroy(other.gameObject);
        Instantiate(other.gameObject, new Vector3(0,20,22.21f), new Quaternion());
    }
}
