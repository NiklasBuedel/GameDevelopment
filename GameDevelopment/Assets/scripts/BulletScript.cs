using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float BulletSpeed = 5f;
    public Rigidbody2D rb2d;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0, BulletSpeed);

        //Asteroid wird zerst�rt wenn er au�erhalb des Bildschirms ist
        if (transform.position.y > screenBounds.y * 2)
        {
            Destroy(this.gameObject);
        }
    }
}
