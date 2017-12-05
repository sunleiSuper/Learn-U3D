using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

    private void Start()
    {
        var c = GetComponent<Collider>();
        c.isTrigger = true;
    }
    // Update is called once per frame
    void Update () {
        //旋转
        //Time.deltaTime 上一帧 - 这一帧的时间
        transform.Rotate(new Vector3(30,30,30) * Time.deltaTime);
	}
}
