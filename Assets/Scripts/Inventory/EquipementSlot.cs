using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipementSlot : ItemContainer
{
    [System.Serializable]
    public enum containerType
    {
        Weapon = 0,
        Implant = 1
    }

    public containerType type;

    public bool TryAddEquipement(Item _item)
    {
        if (type == containerType.Weapon && (_item.itemType == Type.MeleeWeapon || _item.itemType == Type.DistanceWeapon || _item.itemType == Type.HealWeapon))
        {
            return true;
        }
        else if (type == containerType.Implant && _item.itemType == Type.Implant)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
