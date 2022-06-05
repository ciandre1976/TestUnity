using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void Play(string name)
    {
        SceneManager.LoadScene("Game");
    }
}

