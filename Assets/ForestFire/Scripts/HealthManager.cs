using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float animalMaxHealth = 5.0f;
    public float animalCurrentHealth;
    public float fireDamage = 1.0f;

    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        animalCurrentHealth = animalMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            animalCurrentHealth = animalCurrentHealth - fireDamage;
        }
    }
}
