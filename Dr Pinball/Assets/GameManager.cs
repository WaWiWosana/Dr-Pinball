using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int tally = 0;
    public int lives = 3;
    public int ballsInPlay = 0;
    public int malfGoal = 20;
    [SerializeField]
    private GameObject ballSpawn;
    [SerializeField]
    private GameObject ball;
    void Start()
    {
        Instantiate(ball, ballSpawn.GetComponent<Transform>().position, ballSpawn.GetComponent<Transform>().rotation);
        lives -= 1;
        ballsInPlay += 1;
    }

    void Update()
    {

    }
}
