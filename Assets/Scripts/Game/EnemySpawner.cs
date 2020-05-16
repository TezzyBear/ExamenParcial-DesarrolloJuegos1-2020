using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public List<GameObject> enemies;
    private double elapsed = 0.0f;
    float xHalfWidth;

    private void Start()
    {
        xHalfWidth = Camera.main.orthographicSize;
    }

    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 2f) {
            elapsed = 0f;
            
            int index = Random.Range(0, enemies.Count - 1);
            float xSpawn = Random.Range(-xHalfWidth, xHalfWidth);
 
            Instantiate(enemies[index], new Vector3(xSpawn, transform.position.y, 0f), Quaternion.identity);            
        }
    }
}

