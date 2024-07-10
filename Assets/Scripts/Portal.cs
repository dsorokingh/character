using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : CharacterInteraction
{
    public Portal exitPortal;

    public override void Interact()
    {
        character.transform.position = exitPortal.transform.position;
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
