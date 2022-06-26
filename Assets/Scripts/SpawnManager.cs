using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List <GameObject> fruitsAndHerbs;
    [SerializeField] float gravityModifier;
    [SerializeField] private bool isGameOverOwn = true;
    int randomNumber;
    Vector3 spawnLocation;
    // private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObjects", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        if(isGameOverOwn == false)
        {
            randomNumber = Random.Range(0, 5);
            spawnLocation = new Vector3(30, 60, Random.Range(28, 88));
            Instantiate(fruitsAndHerbs[randomNumber],spawnLocation , fruitsAndHerbs[randomNumber].transform.rotation);
            Physics.gravity *= gravityModifier; 
        }
    }

    public void IsGameOver(bool isGameOver)
    {
        isGameOverOwn = isGameOver;
    }
}
