using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject bullet;
    public Transform firePoint;
    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }


        transform.LookAt(target);
    }
}
