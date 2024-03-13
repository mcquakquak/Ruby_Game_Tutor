using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    public GameObject Throwing_Knife;
    public Animator animator;
    public Vector2 lookDirection = new Vector2(1,0);
    public Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 5f * horizontal * Time.deltaTime;
        position.y = position.y + 5f * vertical * Time.deltaTime;
        transform.position = position;

        Vector2 move = new Vector2(horizontal, vertical);
        
        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        
        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);
        if (Input.GetKeyDown(KeyCode.C))
        //if (Input.GetButton("Fire1"))

        {
            Launch();
        }
    }

  void Launch()
    {
        Debug.Log("HOLA SOY DORA");
        GameObject projectileObject = Instantiate(Throwing_Knife, rb.position + Vector2.up * 0.5f, Quaternion.identity);
        Debug.Log(projectileObject);
        Projectiles projectile = projectileObject.GetComponent<Projectiles>();
        projectile.Launch(lookDirection, 500);

    }

}
