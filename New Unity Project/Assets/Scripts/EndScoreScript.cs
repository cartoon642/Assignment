using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndScoreScript : MonoBehaviour {

    int player1total;
    int player2total; 
    public Text text;
    public Text player1scoretext;
    public Text player2scoretext;
    

    void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {

        player2total = goalscript.player2total;
        player1total = goalscript.player1total;
        if (player2total < player1total)
        {
            text.text = "player 1 Wins";
        }
        if (player1total < player2total)
        {
            text.text = "player 2 Wins";
        }
        if (player1total == player2total)
        {
            text.text = "Wow You both got equal points!";
        }
        player1scoretext.text = "player 1 got " + player1total;
        player2scoretext.text = "player 2 got " + player2total;
        

    }
}
