using UnityEngine;
using System.Collections;

public class Dummy : MonoBehaviour {

    Transform t;
    public Vector3 deplacement = new Vector3(1, 0, 0);

	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
        if (t == null) Debug.Log("No Transform");
	
	}
	
	// Update is called once per frame
	void Update () {
        t.position = t.position + deplacement * Time.deltaTime;
        
	}
}
