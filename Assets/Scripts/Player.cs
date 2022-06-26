using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float speedBox;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 90)
        {
            transform.position = new Vector3(30, ((float)(5.30)), 90);
        }

        else if(transform.position.z < 25)
        {
            transform.position = new Vector3(30, ((float)(5.30)), 25);

        }
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speedBox);
        }
    }

    public void scoreSet(int refscore)
    {
        scoreText.SetText("SCORE: " + refscore);
    }
}
