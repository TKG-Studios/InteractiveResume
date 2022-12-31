using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.InventoryEngine;
public class TriggerVolume : MonoBehaviour
{
    public Inventory[] inventories;
    public AudioSource madeIt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            madeIt.Play();
            collision.GetComponentInChildren<SwitchAnimController>().SwitchBack();

            collision.GetComponent<CharacterHandleWeapon>().CurrentWeapon.enabled = false;
            collision.GetComponent<CharacterHandleWeapon>().CurrentWeapon.gameObject.SetActive(false);

            foreach (Inventory inventory in inventories)
            {
                inventory.EmptyInventory();
                inventory.ResetSavedInventory();
            }
        }
        this.enabled = false;

    }
}
