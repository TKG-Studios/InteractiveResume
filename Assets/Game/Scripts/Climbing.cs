using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class Climbing : MonoBehaviour
{
    private Animator anim;

    private void OnEnable()
    {
        OpeningItemPicker.openingItemGet += GetAnimController;
    }

    private void OnDisable()
    {
        OpeningItemPicker.openingItemGet -= GetAnimController;
    }
 

    public void GetAnimController()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (anim != null)
        {
            if (anim.GetBool("LadderClimbing"))
            {
                StartCoroutine(RemoveBlasterSprite());
            }
            else
            {
                StartCoroutine(AddBlasterSprite());
               
            }
        }
   
    }

    IEnumerator RemoveBlasterSprite()
    {
        yield return new WaitForSeconds(.2f);
        GetComponentInParent<CharacterHandleWeapon>().CurrentWeapon.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }

    IEnumerator AddBlasterSprite()
    {
        yield return new WaitForSeconds(.2f);
        GetComponentInParent<CharacterHandleWeapon>().CurrentWeapon.GetComponentInChildren<SpriteRenderer>().enabled = true;
    }
}
