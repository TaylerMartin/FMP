using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {

    public float CurrentFood;
    public float CurrentWater;
    private float MaxFood;
    private float MaxWater;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool AddWater(Storage origin, float amount)
    {
        if (origin.CurrentWater >= amount)
        {
            CurrentWater += amount;
            origin.CurrentWater -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool AddFood(Storage origin, float amount)
    {
        if (origin.CurrentFood >= amount)
        {
            CurrentFood += amount;
            origin.CurrentFood -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
