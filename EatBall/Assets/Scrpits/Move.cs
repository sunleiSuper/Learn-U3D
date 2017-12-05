using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Rigidbody rigid;
    public float speed = 5.0f;

    public UnityEngine.UI.Text tips;
    int count = 0;

    //第一帧的时候调用
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
    //每帧刷新的时候调用
	void Update () {
        //水平 
        float h = Input.GetAxis("Horizontal");
        //垂直
        float v = Input.GetAxis("Vertical");

        var movement = new Vector3( h , 0 , v );

        rigid.AddForce(movement * speed);  
    }

    //当触发碰撞时调用的方法
    private void OnTriggerEnter(Collider other){
        Debug.Log("OnTriggerEnter");
        //如果含有Pickups组件的话
        if (other.GetComponent<Pickups>()){
            //隐藏
            other.gameObject.SetActive(false);
            count++;
            RefreshTips();
        }
    }

    void RefreshTips() {
        tips.text = "分数 : "+count.ToString();
        if (count >= 8) {
            tips.text = "Win!!!";
        }
    }
}
