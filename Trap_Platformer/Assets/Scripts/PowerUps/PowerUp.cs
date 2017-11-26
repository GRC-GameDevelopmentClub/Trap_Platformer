using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    private ParticleSystem pickupEffect;
    private GameObject player;
    private PowerUpEffect powerEffect;
    PlayerStats playerStats;

    void Start()
    {
        pickupEffect = GetComponent<ParticleSystem>();
       
        powerEffect = GetComponent<PowerUpEffect>();
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject;

        if (collision.CompareTag("Player"))
        {
            powerEffect.PlayerStats = player.GetComponent<PlayerStats>();
            Debug.Log("POWRR PLAYER STATS" + playerStats);

            Pickup(collision);
           
        }

    }

    void Pickup(Collider2D player)
    {
        if (!powerEffect.isBeingUsed)
        {
            // spawn cool effect
            // Instantiate(pickupEffect, transform.position, transform.rotation);

            // Apply effect to player
            Debug.Log("methhead" + GetPlayerStats());
            Debug.Log("statsbruh"+playerStats);
            powerEffect.Use();

            // remove powerup object

            GetComponent<SpriteRenderer>().enabled = false;           

        }
    }

    public PlayerStats GetPlayerStats()
    {
        return playerStats;
    }

}
