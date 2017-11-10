using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public float speed = 2;
    public float translationSpeed = 1;
    public float translationRange = 10;
    Vector3 velocity;
    float translation = 0;

    // Use this for initialization
    void Start () {
    
    	
	}
	
	// Update is called once per frame
	void Update () {

        translation += translationSpeed * Time.deltaTime;
        velocity = new Vector3(speed, Mathf.Cos(translation) * translationRange * translationSpeed, 0);


        transform.position += velocity * Time.deltaTime;		

	}
}
