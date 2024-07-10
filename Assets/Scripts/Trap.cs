using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : CharacterInteraction
{
    public float damage = 40f;

    public override void Interact()
    {
        character.TakeDamage(damage);
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
