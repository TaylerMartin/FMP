using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    Food,Water,Stone,Wood,Nothing
}

public class Inventory : MonoBehaviour
{
    public ObjectType InventoryContains;
    public int InventoryAmount;

    private void Update()
    {
        if (InventoryAmount <= 0)
        {
            InventoryAmount = 0;
            InventoryContains = ObjectType.Nothing;
        }
    }
}
