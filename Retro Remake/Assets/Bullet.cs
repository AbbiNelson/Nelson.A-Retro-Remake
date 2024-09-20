using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float moveSpeed = 10.0f;
    private Score score;
    void Start()
    {
        bullet = this.gameObject.GetComponent<Rigidbody2D>();
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = new Vector2(0, 1) * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.SetActive(false);
            score.currentScore+= 10;
        }
    }
}
