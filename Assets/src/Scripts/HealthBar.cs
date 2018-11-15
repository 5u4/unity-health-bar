using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public float dropSpeed = 0.5f;

    private float maxHealth;
    private float currentHealth;

    private float dropEffectPercentage = 1;

    private Image healthBar;
    private Image dropEffect;

    public float GetMaxHealth() {
        return maxHealth;
    }

    public float GetCurrentHealth() {
        return currentHealth;
    }

    public void SetMaxHealth(float maxHealth) {
        this.maxHealth = maxHealth;
    }

    public void SetCurrentHealth(float currentHealth) {
        this.currentHealth = currentHealth;
    }

    private void Start() {
        healthBar = transform.Find("Health").GetComponent<Image>();
        dropEffect = transform.Find("DropEffect").GetComponent<Image>();
    }

    private void Update() {
        float healthPercentage = Mathf.Min(Mathf.Max(0, currentHealth / maxHealth), 1);

        /* Update health bar */
        healthBar.fillAmount = healthPercentage;

        /* Handle drop effect */
        if (dropEffectPercentage > healthPercentage) {
            dropEffectPercentage -= Time.deltaTime * dropSpeed;
            dropEffect.fillAmount = dropEffectPercentage;
        } else {
            dropEffectPercentage = healthPercentage;
        }
    }

}
