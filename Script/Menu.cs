using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	void Start () {
		
	}
    public void kontrol(int a)
    {
        if (a == 1)
        {
            Arabacontrol.gg = false;
            SceneManager.LoadScene("SampleScene");
        }
        if (a == 2)
        {
            Arabacontrol.gg = false;
            SceneManager.LoadScene("SampleScene2");
        }
        if (a == 0)
        {
            Application.Quit();
        }
    }

	

	void Update () {
		
	}
}
