using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{

    [Header("Eat Food Variables")]
    public float FoodMultiplier;

    [Header("Drink Water Variables")]
    public float WaterMultiplier;

	public bool EatFood(Inventory EatFrom, Work Villager, int amount)
    {
        if (EatFrom.InventoryAmount >= amount && EatFrom.InventoryContains == ObjectType.Food)
        {
            Villager.Hunger -= amount * FoodMultiplier;
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public bool DrinkWater(Inventory EatFrom, Work Villager, int amount)
    {
        if (EatFrom.InventoryAmount >= amount && EatFrom.InventoryContains == ObjectType.Water)
        {
            Villager.Thirst -= amount * WaterMultiplier;
            return true;
        }
        else
        {
            return false;
        }

    }
}
