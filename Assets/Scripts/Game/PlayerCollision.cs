using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision: MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag != gameObject.tag) {
            print("Here I am!");
            PlayerController.instance.points += 10;
            Destroy(other.gameObject);
        } else {
            PlayerController.instance.lifes -= 1;
        }
    }
}
