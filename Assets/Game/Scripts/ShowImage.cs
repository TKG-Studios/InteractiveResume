using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MoreMountains.CorgiEngine {
    public class ShowImage : MonoBehaviour
    {
        public GameObject ImageToShow;

        private void OnEnable()
        {
            GetComponent<Health>().OnDeath += RevealImage;
        }
        void Start()
        {
            ImageToShow.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void RevealImage()
        {
            ImageToShow.SetActive(true);
        }
    }
}
