using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject cookedChicken;

    [SerializeField] private float fireDamage = 1.0f;

    private float animalMaxHealth = 20.0f;
    private float animalCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        //set animal current health
        animalCurrentHealth = animalMaxHealth;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    //reduce chicken health on collision, if it reaches 0, destroy the chicken and replace with cooked chicken gameobject
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            animalCurrentHealth -= fireDamage;

            if (animalCurrentHealth == 0)
            {
                Destroy(gameObject);
                Instantiate(cookedChicken, transform.position, transform.rotation);
                //update number of cooked chicken variable
                gameManager.UpdateCookedChicken(1);
            }
        }
    }
}
