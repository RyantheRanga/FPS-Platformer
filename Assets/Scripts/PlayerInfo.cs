using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public float Health = 100f;
    public int points;

    public GameObject playerinfo;
    public PlayerMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public void EnemyHit(float DamageAmount)
    {
        Health -= DamageAmount;

        if(Health <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        movement.enabled = false;
    }

    public void PointGain()
    {
        points = points + 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
