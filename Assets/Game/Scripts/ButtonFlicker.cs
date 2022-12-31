using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFlicker : MonoBehaviour
{
    public Text buttonText;
    public float flickerSpeed = 40f;
    public float flickerDuration = 1f;

    public void StartButtonFlicker()
    {
        StartCoroutine(ButtonFlickerCoroutine());
    }

    IEnumerator ButtonFlickerCoroutine()
    {
        float t = 0;
        while (t < flickerDuration)
        {
            float i = Mathf.Sin(Time.time * flickerSpeed);
            buttonText.enabled = (i > 0);
            t += Time.deltaTime;
            yield return null;
        }
        buttonText.enabled = true;
    }
}
