using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.InventoryEngine;

namespace MoreMountains.CorgiEngine {
public class EnableDoubleJump : ItemPicker
{
        public delegate void DoubleJumpGet();
        public static event DoubleJumpGet doubleJumpGet;

        public override void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                
                collision.GetComponent<CharacterJump>().NumberOfJumps = 2;
                if (doubleJumpGet != null) doubleJumpGet();
            }
        }
    }
}

