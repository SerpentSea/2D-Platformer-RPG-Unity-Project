using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EquipmentSO : ScriptableObject
{
    public string itemName;
    public int strength, defense;

    public void EquipItem()
    {
        PlayerStats playerstats = GameObject.Find("StatManager").GetComponent<PlayerStats>();
        playerstats.strength += strength;
        playerstats.defense += defense;

        playerstats.UpdateEquipmentStats();
    }

    public void UnEquipItem()
    {
        PlayerStats playerstats = GameObject.Find("StatManager").GetComponent<PlayerStats>();
        playerstats.strength -= strength;
        playerstats.defense -= defense;

        playerstats.UpdateEquipmentStats();
    }
}