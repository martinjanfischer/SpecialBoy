using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsurpatorBehaviour : MonoBehaviour//, IDamageable
{
    Animator animator;
    GameObject player;

    public bool schlaeft  = true;
    public bool Angriff = false;

    public float radius = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionDrache= transform.position;
        Vector3 positionplayer = player.transform.position;
        float distanz = Vector3.Distance(positionplayer, positionDrache);

        bool playerInReichweite = distanz < radius;
        if (schlaeft && playerInReichweite)
        {
            animator.SetBool("schlafen", false);
            schlaeft = false;
        }
        if (!schlaeft && !playerInReichweite)
        {
            animator.SetBool("schlafen", true);
            schlaeft = true;
        }
    }
}