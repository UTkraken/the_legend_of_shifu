using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health) {
        slider.value = health;
    }

    public void looseHealth(int health) {
        slider.value -= health;
    }

    public bool CheckHealth() {
        if (slider.value == 0) {
            return true;
        }
        else {
            return false;
        }
    }
}