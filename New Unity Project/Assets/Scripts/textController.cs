using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textController : MonoBehaviour {

    public Text player1;
    public Text player2;
    int player1score;
    int player2score;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player1.text =(GameObject.FindGameObjectWithTag("player1score").GetComponent<goalscript>().playerscore).ToString();
        player2.text = (GameObject.FindGameObjectWithTag("player2score").GetComponent<goalscript>().playerscore).ToString();

    }
}
