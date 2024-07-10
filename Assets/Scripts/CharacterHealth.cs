using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : CharacterModule
{
    public UIManager uIManager;
    public float maxHealth = 100f;
    public float health;

    public void Heal(float value)
    {
        health = Mathf.Clamp(health + value, 0, maxHealth);

        uIManager.UpdateCharacterHealthSlider(health);
    }

    public void TakeDamage(float value)
    {
        health = Mathf.Clamp(health - value, 0, maxHealth);

        uIManager.UpdateCharacterHealthSlider(health);
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        uIManager.UpdateCharacterHealthSlider(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
