using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class RobotIA : MonoBehaviour {

    NavMeshAgent nav;
    GameObject player;
    float timerPathPlanning;
    Animator anim;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("vitesse", nav.desiredVelocity.magnitude);

        timerPathPlanning += Time.deltaTime;
        if(timerPathPlanning > 0.3f)
        {
            nav.SetDestination(player.transform.position);
            timerPathPlanning = 0f;
        }

        float distance = (player.transform.position - transform.position).magnitude;
        bool proche = (distance < 4);
        anim.SetBool("attack", proche);
	    
	}
}
