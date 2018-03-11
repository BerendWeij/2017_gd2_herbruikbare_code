using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    GameObject player;
    public GameObject[] hit;
    PlayerHealth playerHealth;
    private int _attackDamage = 10;
    private Rigidbody _rb;
    private float speed = 100;
   
    void Start () {
        
        playerHealth = player.GetComponent<PlayerHealth>();
        _rb = GetComponent<Rigidbody>();
    }
	
	
	void FixedUpdate () {
        Vector3 velocity = transform.forward * speed * Time.fixedDeltaTime;
        _rb.MovePosition(_rb.position + velocity);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage(_attackDamage);
                Destroy(gameObject);
            }
        }
    }
}
