using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour {
    public Vector3 moveplayer1;

    // Use this for initialization
    void Start () {
        moveplayer1 = new Vector3(gameObject.transform.position.x, (gameObject.transform.position.y) + 1, gameObject.transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            moveplayer1 = new Vector3(gameObject.transform.position.x,(gameObject.transform.position.y)-0.1f, gameObject.transform.position.z);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveplayer1 = new Vector3(gameObject.transform.position.x, (gameObject.transform.position.y )+0.1f, gameObject.transform.position.z);
        }
        moveplayer1.y = Mathf.Clamp(moveplayer1.y, -3.81f, 3.81f);
        gameObject.transform.position = moveplayer1;
    }
}
