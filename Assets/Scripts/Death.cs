using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    bool isDead = false;
    [SerializeField] AudioSource collisionSound;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody") && !isDead)
        {
            death();
            Invoke(nameof(ReloadLevel), 2f);
        }
    }
    private void death()
    {
        isDead = true;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Movement>().enabled = false;
        collisionSound.Play();
        animator.SetTrigger("Death");
    }
    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}