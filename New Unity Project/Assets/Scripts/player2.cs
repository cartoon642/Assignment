using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {

    public Vector3 movePaddle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousepos = Input.mousePosition.y;
        movePaddle = new Vector3(gameObject.transform.position.x, mousepos / Screen.height * 10 - 5, gameObject.transform.position.z);
        movePaddle.y = Mathf.Clamp(movePaddle.y, -3.81f, 3.81f);
        
        gameObject.transform.position = movePaddle;
    }
}
