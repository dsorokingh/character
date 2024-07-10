using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public abstract class CharacterInteraction : CharacterModule
{
    public UIManager uIManager;

    protected Coroutine ePressCoroutine;

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ePressCoroutine = StartCoroutine(IsEPressed());

            uIManager.ShowInteractionText();
        }
    }

    protected virtual IEnumerator IsEPressed()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.E)) Interact();
            yield return null;
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine(ePressCoroutine);

            uIManager.HideInteractionText();
        }
    }

    protected virtual void DeleteInteractionObject()
    {        
        uIManager.HideInteractionText();
        Destroy(gameObject);
    }

    public abstract void Interact();

    
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
