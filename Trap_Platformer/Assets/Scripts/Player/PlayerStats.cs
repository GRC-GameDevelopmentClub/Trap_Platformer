using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float health = 10.0f;
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    public float scale = 1.0f;
    public Color color;

    private List<float> stats;

    void Start()
    {
        stats = new List<float>();
        stats.Add(health); // 0
        stats.Add(speed); // 1
        stats.Add(jumpForce); //2
        stats.Add(scale); // 3

        color = Color.white;

    }

    public void RestStats()
    {
        health = stats[0];
        speed = stats[1];
        jumpForce = stats[2];
        scale = stats[3];
        color = Color.white;
    }
}
