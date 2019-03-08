using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class yeeees : MonoBehaviour
{
    [SerializeField] private FpsMovement player;
    [SerializeField] private EnemyMovement enemy;
    [SerializeField] private Text scoreLabel;
    private int score;
    // Start is called before the first frame update
    private bool isTouched = false;
    void Start()
    {
        isTouched = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("true");
            isTouched = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
       if (isTouched)
        {
            Debug.Log("losed a point");
            score = 0;
            scoreLabel.text = score.ToString();
        }
        isTouched = false;
    }
}
