using UnityEngine;
using System.Collections;

public class Transparent : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Poulet")
        {
            Debug.Log("Trigger");
        }
    }
}
