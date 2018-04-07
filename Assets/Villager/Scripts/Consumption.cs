using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumption : MonoBehaviour
{

    private Work workRef;
    private float HungerTick;
    private float ThirstTick;
    private float HungerIncrementer;
    private float ThirstIncrementer;
    // Use this for initialization
    void Start()
    {
        workRef = GetComponent<Work>();
        HungerTick = 1f;
        ThirstTick = 1f;
        HungerIncrementer = 1f;
        ThirstIncrementer = 1f;
        StartCoroutine(GainHunger());
        StartCoroutine(GainThirst());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GainHunger()
    {
        while (true)
        {
            yield return new WaitForSeconds(HungerTick);
            if (!workRef.IsDead)
            {
                workRef.Hunger += ThirstIncrementer;
            }

        }
    }
    IEnumerator GainThirst()
    {
        while (true)
        {
            yield return new WaitForSeconds(ThirstTick);
            if (!workRef.IsDead)
            {
                workRef.Thirst += ThirstIncrementer;
            }
        }

    }
}
