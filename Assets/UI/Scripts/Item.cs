using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Pistol,
        Rifle,
        Shotgun
    }

    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.Pistol:
                return 1000;
            case ItemType.Rifle:
                return 3500;
            case ItemType.Shotgun:
                return 3500;
        }
    }

    public static GameObject GetPrefab(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.Pistol:
                return (GameObject)Resources.Load("Weapons/PistolController");
            case ItemType.Rifle:
                return (GameObject)Resources.Load("Weapons/RifleController");
            case ItemType.Shotgun:
                return (GameObject)Resources.Load("Weapons/ShotgunController");
        }
    }
}
