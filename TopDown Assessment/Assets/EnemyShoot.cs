using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float shootSpeed = 0.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    float timer = 0;
    public float shootTriggerDistance = 30;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            Vector2 shootDirection = new Vector2(player.position.x - transform.position.x,
                player.position.y - transform.position.y);
        if (timer > shootDelay && shootDirection.magnitude < shootTriggerDistance)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //get player position
            //player.position = Camera.main.ScreenToWorldPoint(player.position);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}
