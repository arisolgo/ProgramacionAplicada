using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCar : Car
{
   

	public override void move()
    {
        transform.Translate(new Vector2(0f, speed * Time.deltaTime));
    }

	public override void OnTriggerEnter2D(Collider2D collision)
	{
		base.OnTriggerEnter2D(collision);

        if(collision.tag == "Intersection") { onIntersection = true; }
    
	}
    public override void trafficControl()
	{
        if (GameObject.Find("Controller").GetComponent<Controller>().twoThree)
        {
            speed = previousSpeed; 
        }

        else if (!GameObject.Find("Controller").GetComponent<Controller>().twoThree)
        {
            if (onIntersection) speed = previousSpeed;
            else speed = 0;
        }
    }



}
