using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    private Rigidbody animalRb;

    [SerializeField] private float movementStrength = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    //knock chickens away from fire on collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            //calculate direction animal will bounce towards by subtracting it's current position from fire position
            Vector3 moveAway = collision.transform.position - gameObject.transform.position;

            //immediately apply force to enemy multiplied by powerup strength, push away using moveAway variable
            animalRb.AddForce(moveAway * movementStrength, ForceMode.Impulse);
        }
    }
}
