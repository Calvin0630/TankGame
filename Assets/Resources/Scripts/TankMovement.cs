using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {
    public float acceleration, maxSpeed;
    Rigidbody rBody;
	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody>();
        if (maxSpeed == 0 || acceleration ==0) print("TankMovement.speed == 0 || TankMovement.acceleration == 0");
	}
	
	// Update is called once per frame
	void Update () {
        print(gameObject.transform.forward);
        rBody.AddForce(gameObject.transform.forward * acceleration * Input.GetAxis("Vertical"));
	}
}
