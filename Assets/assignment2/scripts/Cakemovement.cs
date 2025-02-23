using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMovement : MonoBehaviour
{
    public float speed = 3f; // moving spped
    private float destroyX; // the position of destroy poiny

    void Start()
    {
   destroyX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 1f; // the destroy point
    }

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime; // cake moving with time to the right

        if (transform.position.x > destroyX)//destroy the cake when out of the screen
        {
            Destroy(gameObject);
        }
    }
}