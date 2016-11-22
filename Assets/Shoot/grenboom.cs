using UnityEngine;
using System.Collections;

public class grenboom : MonoBehaviour {

    float timerGren;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timerGren += Time.deltaTime;
        if (timerGren > 10f)
        {
            Destroy(this.gameObject);
            Instantiate(grenboom, transform.position, Quaternion.identity) as GameObject;
            timerGren = 0f;
        }
    }
}
