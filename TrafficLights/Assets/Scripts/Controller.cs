using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<GameObject> S1;
    public List<GameObject> S2;
    public List<GameObject> S3;
    public List<GameObject> S4;
    public bool oneFour;
    public bool twoThree;
    public float speed;
    


    // Start is called before the first frame update
    void Start()
    {
        initialState();
        speed = 1;
        
       // StartCoroutine(trafficLightEnumerator());
       
        Time.timeScale = speed;
      
        trafficLight();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = speed;
    }

    public void setSpeed(float newSpeed)
	{
       speed = newSpeed;
	}

    public void normalSpeed()
    {
        speed = 1;
    }

    public void mediumSpeed()
    {
        speed = 5;
    }

    public void fastSpeed()
    {
        speed = 10;
    }


    async void trafficLight()
    {
        while (true && speed>0)
		{
            TrafficLight_G_1_4();

            await Task.Delay(TimeSpan.FromSeconds(Time.timeScale));
            TrafficLight_Y_1_4();
            await Task.Delay(TimeSpan.FromSeconds(Time.timeScale));
            TrafficLight_G_2_3();
            await Task.Delay(TimeSpan.FromSeconds(Time.timeScale));
            TrafficLight_Y_2_3();
            await Task.Delay(TimeSpan.FromSeconds(Time.timeScale));
        }

      

    }
    


    void TrafficLight_G_1_4()
	{
        S1[0].SetActive(true);
        S1[1].SetActive(false);
        S1[2].SetActive(false);

        S2[0].SetActive(false);
        S2[1].SetActive(false);
        S2[2].SetActive(true);

        S3[0].SetActive(false);
        S3[1].SetActive(false);
        S3[2].SetActive(true);

        S4[0].SetActive(true);
        S4[1].SetActive(false);
        S4[2].SetActive(false);

        oneFour = true;
        twoThree = false;

    }

  
    void TrafficLight_Y_1_4()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(true);
        S1[2].SetActive(false);

        S2[0].SetActive(false);
        S2[1].SetActive(false);
        S2[2].SetActive(true);

        S3[0].SetActive(false);
        S3[1].SetActive(false);
        S3[2].SetActive(true);

        S4[0].SetActive(false);
        S4[1].SetActive(true);
        S4[2].SetActive(false);

        oneFour = true;
        twoThree = false;
    }

    void TrafficLight_G_2_3()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(false);
        S1[2].SetActive(true);

        S2[0].SetActive(true);
        S2[1].SetActive(false);
        S2[2].SetActive(false);

        S3[0].SetActive(true);
        S3[1].SetActive(false);
        S3[2].SetActive(false);

        S4[0].SetActive(false);
        S4[1].SetActive(false);
        S4[2].SetActive(true);

        oneFour = false;
        twoThree = true;

    }

    void TrafficLight_Y_2_3()
    {
        S1[0].SetActive(false);  
        S1[1].SetActive(false);  
        S1[2].SetActive(true);   

        S2[0].SetActive(false);  
        S2[1].SetActive(true);  
        S2[2].SetActive(false);  

        S3[0].SetActive(false);  
        S3[1].SetActive(true);  
        S3[2].SetActive(false);   

        S4[0].SetActive(false);  
        S4[1].SetActive(false);   
        S4[2].SetActive(true);  

        oneFour = false;
        twoThree = true;

    }


    void initialState()
	{
        for(int i=0; i<=2; i++)
		{
            S1[i].SetActive(false);
            S2[i].SetActive(false);
            S3[i].SetActive(false);
            S4[i].SetActive(false);

        }
    }
}
