using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickmove : MonoBehaviour {
    int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ( count == 0 )
        {
            Vector3 movebrick1 = new Vector3(gameObject.transform.position.x, (gameObject.transform.position.y) + 0.05f, gameObject.transform.position.z);
            gameObject.transform.position = movebrick1;
            if (movebrick1.y >= 3.9f)
            {
                count = 1;
            }
        }
        if ( count == 1)
        {
            Vector3 movebrick1 = new Vector3(gameObject.transform.position.x, (gameObject.transform.position.y) - 0.05f, gameObject.transform.position.z);
            gameObject.transform.position = movebrick1;
            count = 1;
            if (movebrick1.y <= -3.9f)
            {
                count = 0;
            }
            
        }
    }
}
