using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CI : MonoBehaviour
{
    public Rigidbody2D rd;
    Vector2 xdirection;

    public TMP_Text gameover;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xdirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rd.velocity = xdirection * 3000 * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="zz")
        {
            Destroy(gameObject);
        }
    }
    private void OnTiggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
            gameover.enabled = true;
    }
}