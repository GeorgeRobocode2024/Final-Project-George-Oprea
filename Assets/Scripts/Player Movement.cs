using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController character_Controller;
    private Vector3 move_Direction;
    public float speed = 5f;
    private float gravity = 20f;
    public float jump_Force = 10f;
    private float vertical_Velocity;

    void Awake ()
    {
        character_Controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
