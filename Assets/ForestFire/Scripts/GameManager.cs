using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI cookedChickenText;
    private int cookedChickenAmount;

    // Start is called before the first frame update
    void Start()
    {
        cookedChickenAmount = 0;
    }

    //add cooked chicken to counter using variable that is updated in healthManager
    public void UpdateCookedChicken(int amountToAdd)
    {
        cookedChickenAmount += amountToAdd;
        cookedChickenText.text = "Cooked Chickens: " + cookedChickenAmount;
    }

}
