using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterModule : MonoBehaviour
{
    protected Character character;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        GameObject characterObject = GameObject.FindGameObjectWithTag("Player");
        if (characterObject != null)
        {
            character = characterObject.GetComponent<Character>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
