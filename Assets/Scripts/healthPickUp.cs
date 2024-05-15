using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class healthPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController rubyController = collision.GetComponent<RubyController>();
        if (rubyController != null)
        {
            if (rubyController.currentHealth < rubyController.maxHealth)
            {
                rubyController.changeCurrentHealth(10);
                Destroy(gameObject); //emo 
            }
            
        }
    }
}
