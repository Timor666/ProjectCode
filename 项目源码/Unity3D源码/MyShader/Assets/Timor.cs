using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timor : MonoBehaviour {

    public ParticleSystem ps;

    public GameObject go;


    public bool isFire = false;

    public int number = 100;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            isFire = true;
        }
        else
        {
            isFire = false;
        }


        if (isFire)
        {
            go.SetActive(true);
        }
        else
        {
            go.SetActive(false);
        }




	}
}
