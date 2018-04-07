using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Bed : MonoBehaviour {

    [Header("Properties")]
    public GameObject Villager;

    [Header("Debug Tools")]
    public bool DebugOne = false;
    public bool DebugTwo = false;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (DebugOne)
        {
            GoToBed(GameObject.Find("Villager"));
            DebugOne = false;
        }

        if (DebugTwo)
        {
            GetOutOfBed();
            DebugTwo = false;
        }
	}

    public void GoToBed(GameObject villager)
    {
        Villager = villager;
        Villager.transform.parent = this.transform;
        villager.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void GetOutOfBed()
    {
        if (Villager.transform.parent == this.transform)
        {
            transform.DetachChildren();
        }
    }
}
