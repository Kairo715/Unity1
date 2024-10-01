using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRetry : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("GameMain");
    }
}