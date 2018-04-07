using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour {

    private float DeathThreshold = 40;

    [Header("Resources")]
    public float Energy;
    public float Hunger;
    public float Thirst;
    
    [Header("Conditions")]
    public bool IsDead;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Energy < 0 || Hunger > DeathThreshold || Thirst > DeathThreshold)
        {
            IsDead = true;
        }
	}
}
