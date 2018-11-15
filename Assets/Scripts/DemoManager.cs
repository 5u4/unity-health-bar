using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour {

    public HealthBar healthBar;

    public float maxHealth = 100f;
    public float timeBtwDamage = 0.75f;
    public float damageStep = 30f;
    public float healStep = 30f;

    private bool isDamaging = true;
    private float damageCooldown;

    private float currentHealth;

    private void Start() {
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetCurrentHealth(maxHealth);
        currentHealth = maxHealth;
        damageCooldown = timeBtwDamage;
    }

    private void Update() {
        /* Damaging phase */
        if (isDamaging) {

            /* Damage when cooldown reaches 0 */
            if (damageCooldown <= 0) {
                currentHealth -= damageStep;
                healthBar.SetCurrentHealth(currentHealth);
                damageCooldown = timeBtwDamage;
            }

            /* Decrease damage cooldown */
            else {
                damageCooldown -= Time.deltaTime;
            }

            /* Check if current health is smaller than 0 */
            isDamaging &= currentHealth > 0;
        }

        /* Healing phase */
        else {
            /* Heal */
            currentHealth += Time.deltaTime * healStep;
            healthBar.SetCurrentHealth(currentHealth);

            /* Check if current health is greater than max health */
            isDamaging |= currentHealth >= maxHealth;
        }
    }

}
