using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    GameObject MovementObject;
    [SerializeField]
    float speed;

    Vector3 TempPos;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        TempPos = MovementObject.transform.position;

        if (Input.GetKey("w"))
        {
            TempPos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            TempPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            TempPos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            TempPos.z -= speed * Time.deltaTime;
        }

        MovementObject.transform.position = TempPos;
    }
}
