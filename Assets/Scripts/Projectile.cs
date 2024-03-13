using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Rotate(Vector3.forward * 200f * Time.deltaTime);
    }
    // Update is called once per frame

    public void Launch(Vector2 direction, float force)
    {
        rb.AddForce(direction * force);
        Debug.Log("Knife Thrown");
    }
    public void OnCollision2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
}
