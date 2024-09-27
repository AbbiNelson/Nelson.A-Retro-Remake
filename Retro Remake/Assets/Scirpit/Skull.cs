using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{

    public Sprite Player;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= -2.502)
        {
            transform.Translate(0f, -0.25f, 0f);
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player;
        }
        
    }
}
