using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    // void Update()
    // {
    //     // if (Input.GetKeyDown(KeyCode.R))
    //     // {
    //     //     Time.timeScale = 1;
    //     //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //     // }
    // }

    public void ogi()
    {
        Debug.Log("berhasil");
    }
    public void rem()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
