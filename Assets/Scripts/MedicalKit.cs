using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalKit : CharacterInteraction
{
    public float healthRecovery = 50f;

    public override void Interact()
    {
        character.Heal(healthRecovery);
        DeleteInteractionObject();
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
