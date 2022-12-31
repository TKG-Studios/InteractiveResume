using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButtonSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite spriteToChange;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = spriteToChange;
    }
}
