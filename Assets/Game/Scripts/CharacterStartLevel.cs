using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
    public class CharacterStartLevel : CharacterAbility
    {

        protected bool isGameStarted;

        public delegate void StartGameEvent();
        public static event StartGameEvent startGameEvent;


      
        private new void OnEnable()
        {
            base.OnEnable();
            OpeningItemPicker.openingItemGet += TempControlLoss;
            DoorColliderEnable.controlsDisabled += TempControlLoss;
     
        }

        private new void OnDisable()
        {
            base.OnDisable();
            OpeningItemPicker.openingItemGet -= TempControlLoss;
            DoorColliderEnable.controlsDisabled -= TempControlLoss;
        }
        private void Awake()
        {
            isGameStarted = false;
            GetComponent<CharacterHorizontalMovement>().enabled = false;

        }


        protected override void HandleInput()
        {
            base.HandleInput();
            if (!isGameStarted)
            {
              
                if (_inputManager.StartButton.State.CurrentState == MMInput.ButtonStates.ButtonDown)
                {
                 
                    if (startGameEvent != null) startGameEvent();
                    GetComponent<CharacterHorizontalMovement>().enabled = true;
                    GetComponent<CharacterJump>().AbilityPermitted = true;
                    GetComponent<CharacterLookUp>().AbilityPermitted = true;
                }
            } else
            {
                return;
            }
        }
    
        public void TempControlLoss()
        {
            GetComponent<CharacterHorizontalMovement>().enabled = false;
            GetComponent<CharacterJump>().enabled = false;
            GetComponent<CharacterLookUp>().enabled = false;
            StartCoroutine(RegainControl());
        }
        

        IEnumerator RegainControl()
        {
            yield return new WaitForSeconds(2f);
            GetComponent<CharacterHorizontalMovement>().enabled = true;
            GetComponent<CharacterJump>().enabled = true;
            GetComponent<CharacterLookUp>().enabled = true;

        }

    
    }
}
