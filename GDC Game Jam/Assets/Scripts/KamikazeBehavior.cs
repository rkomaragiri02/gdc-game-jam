using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity * -1, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "city")

        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "shield attack")

        {
            Destroy(gameObject);
        }


    }

}
