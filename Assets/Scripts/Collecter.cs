using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    public GameObject Ruby;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ruby = gameObject;
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null )
        {
            collectible.Collect(Ruby);
        }
    }

}
