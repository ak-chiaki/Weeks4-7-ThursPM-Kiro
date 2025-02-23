using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeSpawner : MonoBehaviour
{
    public GameObject[] cakePrefabs; // save the index of cakes
    private int selectedCakeIndex = 0; // Ui select the index
    private float spawnX; // the positionX of cake
    private float spawnY; // the positionY of cake
   private float lastSpawnTime = 0f; // the time of the cake created last time
   public float spawnCooldown = 3f; // cooldown time

    void Start()
    {
       
       spawnX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 1f;//determin the position that the cake was created
       spawnY = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0)).y;
    }

    void Update()
    {
        
       if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime > spawnCooldown)//create cake when press space, and check the cd time
        {
          SpawnCake();
          lastSpawnTime = Time.time; //record the time of cake was created
        }
    }

    public void SetCakeType(int index)
    {
      selectedCakeIndex = index; // refresh the index
    }

    void SpawnCake() // create the cake
    {
       
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, -1); // the position where the cake was created
        GameObject newCake = Instantiate(cakePrefabs[selectedCakeIndex], spawnPosition, Quaternion.identity);
    }
}