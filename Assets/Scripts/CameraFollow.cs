using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    GameObject FollowObject;
    [SerializeField]
    int H_Distance;
    [SerializeField]
    int V_Distance;

    new Vector3 FO_Pos;
    new Vector3 TargetPos;

	void Start () {
        //FO_Pos = FollowObject.transform.position;
	}
	
	void Update () {
        FO_Pos = FollowObject.transform.position;

        TargetPos.y = FO_Pos.y + V_Distance;
        TargetPos.x = FO_Pos.x;
        TargetPos.z = FO_Pos.z - H_Distance;

        this.transform.position = TargetPos;
	}
}
