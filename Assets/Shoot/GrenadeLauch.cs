using UnityEngine;
using System.Collections;

public class GrenadeLauch : MonoBehaviour {

    public Transform GrenadePreFab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1"))
        {
            GameObject grenade = Instantiate(GrenadePreFab, Camera.main.transform.position + Camera.main.transform.forward, Quaternion.identity) as GameObject;
            Vector3 force = Camera.main.transform.forward;
            force.y += 1;
            force = force.normalized * 10;
            grenade.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
        }

	}
}
