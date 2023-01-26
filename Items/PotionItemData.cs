using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion Item Data", menuName = "Item/Potion Item Data")]
public class PotionItemData : ItemData
{
   [Header("Potion Item Data")]
   public int HealthToGive;
}
