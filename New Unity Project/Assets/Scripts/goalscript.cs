using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalscript : MonoBehaviour {
    public int playerscore;
    public static int player1total;
    public static int player2total;

    gamescript game = new gamescript();
    int max;
    string scene;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        max = FindObjectOfType<gamescript>().GetComponent<gamescript>().maxpoints;
        Scene currentScene = SceneManager.GetActiveScene();
        scene = currentScene.name;
        
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    { 
                
            if (scene == "game")
        {
            playerscore++;

            if (this.gameObject.name == "Player1Score")
            {
                player1total = player1total + 1;

            }
            else if (this.gameObject.name == "Player2Score")
            {
                player2total = player2total + 1;
            }

            if (playerscore >= max)
            {
            
                
            
                GameObject.FindGameObjectWithTag("player2score").GetComponent<goalscript>().playerscore = 0;
                GameObject.FindGameObjectWithTag("player1score").GetComponent<goalscript>().playerscore = 0;
                game.loadlevel("level2");



            }
           
        }
        if (scene == "level2")
        {
            playerscore++;
            playerscore++;
            playerscore++;
            if (this.gameObject.name == "Player1Score")
            {
                player1total = player1total + 3;

            }
            else if (this.gameObject.name == "Player2Score")
            {
                player2total = player2total + 3;
            }
            if (playerscore >= max)
            {

               

                GameObject.FindGameObjectWithTag("player2score").GetComponent<goalscript>().playerscore = 0;
                GameObject.FindGameObjectWithTag("player1score").GetComponent<goalscript>().playerscore = 0;
                game.loadlevel("level3");



            }
            
        }
        if (scene == "Level3")
        {
            playerscore++;
            playerscore++;
            playerscore++;
            playerscore++;
            playerscore++;
            if (this.gameObject.name == "Player1Score")
            {
                player1total = player1total + 5;

            }
            else if (this.gameObject.name == "Player2Score")
            {
                player2total = player2total + 5;
            }

            

            if (playerscore >= max)
            {

                

                GameObject.FindGameObjectWithTag("player2score").GetComponent<goalscript>().playerscore = 0;
                GameObject.FindGameObjectWithTag("player1score").GetComponent<goalscript>().playerscore = 0;
                game.loadlevel("End Screen");



            }
           
        }
    }
}
