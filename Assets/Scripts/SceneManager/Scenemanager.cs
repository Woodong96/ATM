using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;
public class Scenemanager : MonoBehaviour
{
    public InputField inputID;
    public InputField inputPS;

    

    public void StartMainScence()
    {
        string Idtxt = inputID.text;
        string Pstxt = inputPS.text;
        string checkPs = PlayerPrefs.GetString("Idtxt");
        if (Pstxt == checkPs)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.LogWarning(checkPs);
        }

    }
}
