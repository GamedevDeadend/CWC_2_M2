using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] SpawnManager spwnMgr;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag("Box") && !other.gameObject.CompareTag("Enivornment") )
        {
            Debug.Log("GameOver");
            spwnMgr.IsGameOver(true);
            restartButton.SetActive(true);
            Destroy(other.gameObject, 1);

        }
    }

    public void IsGameOver()
    {
        spwnMgr.IsGameOver(false);
        startButton.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
