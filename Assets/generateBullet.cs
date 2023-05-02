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
        InvokeRepeating("bullet", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void bullet()
    {
        Instantiate(bullet);
    }

    public void getScore()
    {
        score++;
    }
    
}
