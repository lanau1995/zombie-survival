using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float health;

    [SerializeField] private GameObject healthBarUI;
    [SerializeField] private Slider slider;

    private void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            print("ENEMY HEALTH UPDATED TO: " + health);

            slider.value = CalculateHealth();

            if (health <= 0)
            {

                Destroy(gameObject);
            }
        }
    }

    private float CalculateHealth()
    {
        return health / maxHealth;
    }
}
