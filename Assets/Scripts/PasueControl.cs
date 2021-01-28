using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasueControl : MonoBehaviour
{
    public GameObject myPanel;
    public bool Restle = false;
    public void Pause()
    {
        gameObject.SetActive(false);
        myPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        Time.timeScale = 1;
        gameObject.SetActive(true);
        myPanel.SetActive(false);
    }
    public void Restartt()
    {
        Restle = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menuu()
    {
        Restle = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("1Menu");
    }
}
