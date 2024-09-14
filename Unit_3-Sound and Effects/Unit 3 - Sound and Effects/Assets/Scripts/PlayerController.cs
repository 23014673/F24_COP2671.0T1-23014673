using System.Collections;
using System.Collections.Generic;
using JetBrains.Rider.Unity.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;

    private Animator playerAnim;

    private AudioSource playerAudio;

    public float jumpForce = 10;

    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver;

    public  ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;

    public AudioClip crashSound;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        //playerRb.AddForce(Vector3.up * 100);

        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();

        Physics.gravity *= gravityModifier;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            playerAnim.SetTrigger("Jump_trig");

            dirtParticle.Stop();

            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;

        dirtParticle.Play();

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");

            gameOver = true;

            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);

            explosionParticle.Play();

            dirtParticle.Stop();

            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}