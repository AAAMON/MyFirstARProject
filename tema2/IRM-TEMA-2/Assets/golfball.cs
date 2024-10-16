using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfball-script : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Assuming the golf club has a tag named "GolfClub"
        if (other.CompareTag("golfball-collider"))
        {
            scoreManager.IncrementScore();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
