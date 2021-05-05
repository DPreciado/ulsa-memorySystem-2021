using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using MyLibs.MemorySystem;

public class Game : MonoBehaviour
{
    [SerializeField]
    Button btnPlus;
    [SerializeField]
    Button btnMinus;
    [SerializeField]
    TMP_Text txtHealth;

    int healthValue = 100;

    void Awake()
    {
        btnPlus.onClick.AddListener(PlusClick);
        btnMinus.onClick.AddListener(MinusClick);
    }

    void PlusClick()
    {
        healthValue++;
        UpdateHealthText();
    }
    void MinusClick()
    {
        healthValue = healthValue - 1 > 0 ? healthValue - 1 : 0;
        UpdateHealthText();
    }
    void UpdateHealthText()
    {
        txtHealth.text = $"Health: {healthValue}";
        MemorySystem.NewGame(healthValue);
    }
}
