using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 0;
    public float previousSpeed = 0;
    public Vector3 originalPos;
    public GameObject carClone;
    public bool onIntersection = false;
   
    // Start is called before the first frame update
    public virtual void Start()
    {
        originalPos = gameObject.transform.position;
        speed = 1;
        previousSpeed = speed;

    }

    // Update is called once per frame
    public void Update()
    {
        move();
        trafficControl();
    }

	public virtual void move(){ }
    public void stop()
	{
         speed = 0;
    }

    public void normalSpeed()
	{
        speed = 1;
        previousSpeed = speed;

    }

    public void mediumSpeed()
    {
        speed = 3;
        previousSpeed = speed;

    }

    public void fastSpeed()
    {
        speed = 6;
        previousSpeed = speed;

    }

    public void adjustSpeed(float newSpeed)
	{
        speed = newSpeed;
        previousSpeed = speed;

    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
	{
       if(collision.tag == "Destroyer")
		{
            gameObject.transform.position = originalPos;
            onIntersection = false;
        } 
    }

    public virtual void trafficControl(){}
   // public virtual void inIntersection(){}








}
