using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry : MonoBehaviour, ICollectible
{
    void Start()
    {
        
    }

    public void Collect(GameObject player)
    {
        Debug.Log("BERRY COLLECTED" + player );
        
    }

}
