using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Enemy : MonoBehaviour
{
    public FloatValue maxHealth;
    private float health;
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;


    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth.initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
