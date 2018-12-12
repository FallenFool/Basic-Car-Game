using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zeminkonrol : MonoBehaviour {

    Rigidbody r;
    public static bool car = false;

  
 
   
   

    void Start () {
        r = GetComponent<Rigidbody>();
    
	}
 
    void zeminkontrol()
    {
        if (Arabacontrol.gg==true)
        {
            r.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            r.velocity = new Vector3(0, 0, -70f);
        }
    
        if (gameObject.transform.position.z <= -175){
            car = true;
            Randomcar.a = Random.Range(0, 10);
         
        
            gameObject.transform.position = new Vector3(0, 0.2f, 136.1f);

          
        }
    }

  



    void Update () {
        zeminkontrol();
    
      
       
	}
}
