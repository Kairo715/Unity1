using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageCounter : MonoBehaviour
{
    int damage;

    [SerializeField]
    TMPro.TextMeshProUGUI damageText;
    void Start()
    {
        damage = 3;
    }
    public void AddScore()
    {
        --damage;

        damageText.SetText("HP {0}", damage);

        if (damage <= 0)
        {
            ShowGameOverScreen();
        }
    }
    public void ShowGameOverScreen()
    {
        SceneManager.LoadScene("GameOver");
    }
    void Update()
    {

    }
}