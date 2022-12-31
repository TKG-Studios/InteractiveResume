using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoreMountains.CorgiEngine {
    public class UpdateSignPost : MonoBehaviour
    {
        private void OnEnable()
        {
            CharacterStartLevel.startGameEvent += UpdateSign;
        }
        private void OnDisable()
        {
            CharacterStartLevel.startGameEvent -= UpdateSign;
        }


        public void UpdateSign()
        {
            if (gameObject.name == "OpeningPost")
            {
                Text newText = GetComponentInChildren<Text>();
                newText.text = "You've completed your studies! Now go out and get a job!\n(USE WASD to MOVE)";
                
            }
      
        }


 


    }
}

