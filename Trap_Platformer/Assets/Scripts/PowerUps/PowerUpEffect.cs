using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEffect : MonoBehaviour {

    public float mulitiplier;
    public String effect;
    public float effectTime;
    public bool isBeingUsed;
    

    private PlayerStats playStats;

    public PlayerStats PlayerStats { get { return playStats; } set { playStats = value; } }
   
    // Use this for initialization
    void Start () {
        
	}


    float timer;
	// Update is called once per frame
	void Update () {
        if (isBeingUsed)
        {
            timer += Time.deltaTime;
            if (timer > effectTime)
            {                
                playStats.RestStats();
                isBeingUsed = false;
                timer = 0;
                DestroyObject(this.gameObject);
            }
        }

        
    }

    public void Use()
    {
        if (effect.Equals("Fast"))
        {
            FasterEffect();
        }else if (effect.Equals("Shield"))
        {
            ShieldEffect();
        }else if (effect.Equals("Jump"))
        {
            JumpEffect();
        }

    }

    public void FasterEffect()
    {
        isBeingUsed = true;
        playStats.speed *= mulitiplier;
    }

    public void JumpEffect()
    {
        isBeingUsed = true;
        playStats.jumpForce *= mulitiplier;
        playStats.color = Color.magenta;
    }

    public void ShieldEffect()
    {
        isBeingUsed = true;
        playStats.health *= 10;
    }

}
