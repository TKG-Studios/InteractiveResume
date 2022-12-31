using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.InventoryEngine;
using MoreMountains.Tools;

public class OpeningItemPicker : ItemPicker
{
    public delegate void OpeningItem();
    public static event OpeningItem openingItemGet;

    public override void OnTriggerEnter2D(Collider2D collider)
    {
        base.OnTriggerEnter2D(collider);
        if (openingItemGet != null) openingItemGet();  
      }
    }
