using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dd : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 7)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.up * 400 * Time.deltaTime;
    }
}
