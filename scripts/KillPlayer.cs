using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{


    void OnCollisionEnter(Collision col)
    {

        /*

            Veeti S. - PixelJump 3D
            (C) Copyright 2021-

        */

        if(col.gameObject.tag == "Die")
        {
            Debug.Log("Player died!");
            Respawn();
        }

        if(col.gameObject.tag == "Win")
        {
            Debug.Log("Player won!");
            WinGame();
        }

      

    }

    void Respawn()
    {
        SceneManager.LoadScene("Dead");
    }

    void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

  

  


}
