using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class DummyPhysics : MonoBehaviour
{

    Rigidbody r;
    public float speed = 0.5f;
    public float jumpImpulse = 0.5f;
    public Transform prefabDeath;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //r.AddForce((Camera.main.transform.right)*2);
        Vector3 rightCam = Camera.main.transform.right * speed * 4.0f;
        r.velocity = new Vector3(rightCam.x, r.velocity.y, rightCam.z);

        if (Input.GetButtonDown("Fire1"))
        {
            r.AddForce(new Vector3(0, 20.0f * jumpImpulse, 0), ForceMode.Impulse);
        }
        Vector3 gaze = r.velocity.normalized;
        gaze.y /= 2.0f;
        gaze.y = Mathf.Max(0, gaze.y);
        transform.LookAt(transform.position + gaze);
    }


    public void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
        Instantiate(prefabDeath, transform.position, Quaternion.identity);
    }

}