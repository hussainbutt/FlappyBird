using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{ 
    public Rigidbody bird;
    [SerializeField] float speed = 1f;
    public static float jumpForce = 6f;
    [SerializeField] AudioSource JumpSound;
    
    public void Start()
    {
        bird = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        bird.velocity = new Vector3(speed,bird.velocity.y,bird.velocity.z);
        if (Input.GetButtonDown("Jump"))
        {
            jump();  
        }
    }
    public void jump()
    {
        bird.velocity = new Vector3(bird.velocity.x, jumpForce, bird.velocity.z);
        JumpSound.Play();
    }
}
