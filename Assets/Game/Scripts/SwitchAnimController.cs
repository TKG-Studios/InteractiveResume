using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimController : MonoBehaviour
{
    private Animator initController;
    public RuntimeAnimatorController[] controllers;
  

    private void OnEnable()
    {
        OpeningItemPicker.openingItemGet += SwitchController;
    
    }

    private void OnDisable()
    {
        OpeningItemPicker.openingItemGet -= SwitchController;
    
    }
    void Start()
    {
        initController = GetComponent<Animator>();
    }

   public void SwitchController()
    {
        initController.runtimeAnimatorController = controllers[0];
    }

    public void SwitchBack()
    {
        initController.runtimeAnimatorController = controllers[1];
    }

   
}
