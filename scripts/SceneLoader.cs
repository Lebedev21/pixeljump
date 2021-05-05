using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {

        /*

            PixelJump 3D - Veeti S.
            (C) Copyright 2021-

        */

        SceneManager.LoadScene(sceneName);
    }
}
