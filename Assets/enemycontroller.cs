using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{

    [SerializeField] 

    float speed = 6;
 
    void Start()
    {
        
    }


    void Update()
    {
        Vector2 movementX = new(speed,0);
        transform.Translate(movementX* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Kant"){
            speed = -speed;
        }
    }
}

