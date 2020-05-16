using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Yeah dud");
        other.gameObject.SetActive(false);
    }
}
