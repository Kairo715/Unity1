using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField]
    DamageCounter DamageCanger;
    void OnCollisionEnter(Collision collision)
    {
        DamageCanger.AddScore();
    }
}