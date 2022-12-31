using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.CorgiEngine;

public class UpdatePickUpInformation : MonoBehaviour
{

    public Text informationText;
    private void OnEnable()
    {
        OpeningItemPicker.openingItemGet += ShowBlasterInfo;
        EnableDoubleJump.doubleJumpGet += ShowDoubleJumpInfo;
    }

    private void OnDisable()
    {
        OpeningItemPicker.openingItemGet -= ShowBlasterInfo;
        EnableDoubleJump.doubleJumpGet -= ShowDoubleJumpInfo;
    }


    private void Start()
    {
        informationText.enabled = false;
    }

    public void ShowBlasterInfo()
    {
        informationText.text = "Got Bottle Blaster!";
        informationText.enabled = true;
        StartCoroutine(InfoDisappear());
    }


    public void ShowDoubleJumpInfo()
    {
        informationText.text = "Got Double Jump!";
        informationText.enabled = true;
        StartCoroutine(InfoDisappear());
    }

    IEnumerator InfoDisappear()
    {
        yield return new WaitForSeconds(5f);
        informationText.enabled = false;
    }
}
