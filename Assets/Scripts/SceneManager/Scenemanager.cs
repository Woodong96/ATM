using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartMainScence()
    {
        SceneManager.LoadScene("MainScene");
    }
}
