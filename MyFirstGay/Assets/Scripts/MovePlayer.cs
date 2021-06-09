using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
	float horizontal;
	public Rigidbody2D CircleRigid;
    public int Score = 0;
    public GameObject ScoreText;
    void Start()
    {
        
    }
    public void Count()
    {
        Score++;
        GameObject.Find("Score").GetComponent<Text>().text = "Score: " + Score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Count();
        box unit = collider.GetComponent<box>();
        unit.killBox();
    }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
        	horizontal = Input.acceleration.x;
        }
        if (Input.acceleration.x < 0)
        {
        	gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.acceleration.x > 0)
        {
        	gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        //Input.acceleration.x = Input.acceleration.x > 2.2f ? 2.2f : Input.acceleration.x;


        CircleRigid.velocity = new Vector2(Input.acceleration.x * 10f, CircleRigid.velocity.y);
    }
}
