using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public float score;
    public Text scoreUI;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        score += 100;
        scoreUI.text = "Score : " + score.ToString();
        Destroy(collision.collider.gameObject);
    }
}
