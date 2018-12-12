using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Arabacontrol : MonoBehaviour {
    float yatay;
  public  static bool gg = false;
   public Text t;

    Rigidbody r;
	void Start () {
        r = GetComponent<Rigidbody>();
		
	}
    void Kontrol()
    {
        yatay = Input.GetAxisRaw("Horizontal");
   
        r.velocity = new Vector3(20*yatay, 0,0);
     
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            gg = true;
        }
    }
    void Sahne()
    {
        SceneManager.LoadScene("anamenu");
    }
    void gameover()
    {
        if (gg==true)
        {
            t.text = ("Oyun Bitti");
            Invoke("Sahne", 2);
        }
    }



    void Update () {
        gameover();
        Kontrol();
	}
}
