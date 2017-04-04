using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject LightG;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.red;
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.green;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.white;

        }
    }
}
