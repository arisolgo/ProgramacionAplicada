using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCar : Car
{
   
    public override void move()
    {
        transform.eulerAngles = Vector3.forward * -90;
        transform.Translate(new Vector2(0f, speed * Time.deltaTime));
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.tag == "Intersection") { onIntersection = true; }

    }
    public override void trafficControl()
    {
        if (GameObject.Find("Controller").GetComponent<Controller>().oneFour)
        {
            speed = previousSpeed;
        }

        else if (!GameObject.Find("Controller").GetComponent<Controller>().oneFour)
        {
            if (onIntersection) speed = previousSpeed;
            else speed = 0;
        }
    }

}
