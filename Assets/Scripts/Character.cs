using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    CharacterMovement characterMovement;
    CharacterHealth characterHealth;
        
    // Start is called before the first frame update
    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
        characterHealth = GetComponent<CharacterHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Heal(float value)
    {
        characterHealth.Heal(value);
    }

    public void TakeDamage(float value)
    {
        characterHealth.TakeDamage(value);
    }
}
