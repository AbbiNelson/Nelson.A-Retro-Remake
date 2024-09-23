using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float moveSpeed = 10.0f;
    void Start()
    {
        bullet = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = new Vector2(0, -1) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.SetActive(false);
        }
    }
}
