using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBullet : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getScore()
    {
        score++;
    }
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.ComparingTag("Ground"))
        {
            getScore();
        }
    }
    
}
