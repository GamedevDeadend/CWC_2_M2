using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    [SerializeField] Player player;
    int scoreRef = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // scoreText.SetText("SCORE: " + score);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        scoreRef++;
        player.scoreSet(scoreRef);
    }

}

