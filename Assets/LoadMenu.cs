using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public void loadMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void loadBxh()
    {
        SceneManager.LoadScene(3);
    }
}
