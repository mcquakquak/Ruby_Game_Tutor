using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Damage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController rubyController = collision.GetComponent<RubyController>();
        if (rubyController != null)
        {
           
            
             rubyController.changeCurrentHealth(-20);
             Destroy(gameObject); //emo 
            

        }
    }
}
