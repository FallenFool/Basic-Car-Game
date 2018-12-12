using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomcar : MonoBehaviour {

    public static int a;
	void Start () {
		
	}
    void car()
    {
        if (a < 4)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

	
	
	void Update () {
        car();
        }
    }

