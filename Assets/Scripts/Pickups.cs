using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{

    public int score;
    public int scoreAmount;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score += scoreAmount;
            scoreText.text = "SCORE : " + score;
            Debug.Log(score);
            Destroy(other.gameObject);
        }
    }
}
