using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : CharacterModule
{
    public float speed = 10f;
    float fixedY = 0.5f;
    CharacterController characterController;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        characterController.Move(movement * speed * Time.deltaTime );

        Vector3 fixedPosition = transform.position;
        fixedPosition.y = fixedY;
        transform.position = fixedPosition;
    }

}
