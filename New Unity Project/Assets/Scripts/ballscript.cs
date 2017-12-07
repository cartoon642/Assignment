using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {
    
    public int count;
    public int move;
    public int checkdirectionx;
    public int checkdirectiony;
    public Vector3 moveball;
    
    
    void Start() {

        count = 0;
        moveball = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update() {
       
        if (Input.GetMouseButton(0) && count == 0)
        {

            count = 1;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 2f);
        }


        if (count == 0)
        {

            gameObject.transform.position = moveball;

        }
        //if (move == 0 && checkdirectionx == 0)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        //}
        //if (move == 0 && checkdirectionx == 1)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 5f);
        //}
        //if (move == 1 && checkdirectionx == 0)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
        //}
        //if (move == 1 && checkdirectionx == 1)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -5f);
        //}
        //if (move == 2 && checkdirectiony == 0)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        //}
        //if (move == 2 && checkdirectiony == 1)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
        //}
        //if (move == 3 && checkdirectiony == 0)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 5f);
        //}
        //if (move == 3 && checkdirectiony == 1)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -5f);
        //}
        //if (move == 4 && checkdirectionx == 0)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -1f);
        //}
        //if (move == 4 && checkdirectionx == 1)
        //{
        //    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -1f);
        //}


    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Down" && checkdirectionx == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 10f);
            checkdirectiony = 0;
        }
        if (col.gameObject.name == "Down" && checkdirectionx == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 10f);
            checkdirectiony = 0;
        }
        if (col.gameObject.name == "Up" && checkdirectionx == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
            checkdirectiony = 1;
        }
        if (col.gameObject.name == "Up" && checkdirectionx == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -5f);
            checkdirectiony = 1;
        }
        if (col.gameObject.name == "Left" || col.gameObject.name == "Left 1" && checkdirectiony == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
            checkdirectionx = 0;
        }
        if (col.gameObject.name == "Left" || col.gameObject.name == "Left 1" && checkdirectiony == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
            checkdirectionx = 0;
        }

        if (col.gameObject.name == "Right" || col.gameObject.name == "Right 1" && checkdirectiony == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 5f);
            checkdirectionx = 1;
        }
        if (col.gameObject.name == "Right" || col.gameObject.name == "Right 1" && checkdirectiony == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -5f);
            checkdirectionx = 1;
        }
        if (col.gameObject.name == "player 1" && checkdirectiony == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
            checkdirectionx = 0;
        }
        if (col.gameObject.name == "player 1" && checkdirectiony == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
            checkdirectionx = 0;
        }
        if (col.gameObject.name == "player 2" && checkdirectiony == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 5f);
            checkdirectionx = 1;
        }
        if (col.gameObject.name == "player 2" && checkdirectiony == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -5f);
            checkdirectionx = 1;
        }
        if (col.gameObject.name == GameObject.FindGameObjectWithTag("prefab").name && checkdirectionx == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 1f);
            checkdirectionx = 1;


        }
        if (col.gameObject.name == GameObject.FindGameObjectWithTag("prefab").name && checkdirectionx == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 1f);
            checkdirectionx = 0;


        }

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        count = 0;
       
    }





}
