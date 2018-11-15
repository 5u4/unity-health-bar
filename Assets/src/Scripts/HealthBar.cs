using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;

    public float dropSpeed = 0.5f;

    private float dropEffectPercentage = 1;

    private Image healthBar;
    private Image dropEffect;

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
