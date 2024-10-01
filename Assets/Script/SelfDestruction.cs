using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField]
    ScoreCounter ScoreCanger;
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        ScoreCanger.AddScore();
    }
}