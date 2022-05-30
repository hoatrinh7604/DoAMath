using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    private float value;
    private float maxValue;

    private Slider slider;

    public void SetSlider(float value)
    {
        slider = GetComponent<Slider>();
        this.value = value;
        this.maxValue = value;
        slider.value = this.value;
        slider.maxValue = this.maxValue;
    }

    public void UpdateSlider(float value)
    {
        this.value = value;
        slider.value = this.value;
    }
}
