using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControl : MonoBehaviour
{
    public float MenuyeGecisSuresi;
    const string LVLL = "Lvll_Last";
    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "0MenuOncesi" || SceneManager.GetActiveScene().name == "Kapanis")
        {
            Invoke("Menuu", MenuyeGecisSuresi);
        }
    }
    public void NextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void cikiss()
    {
        Application.Quit();
    }
    public void sahneye_yonelen(string sahne_ismi)
    {
        SceneManager.LoadScene(sahne_ismi);
    }
    public void Menuu()
    {
        SceneManager.LoadScene("1Menu");
    }
    public void Lvl_1()
    {
        sahneye_yonelen("Game01");
    }
    public void Lvl_2()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 2)
        {
            sahneye_yonelen("Game02");
        }
    }
    public void Lvl_3()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 3)
        {
            sahneye_yonelen("Game03");
        }
    }
    public void Lvl_4()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 4)
        {
            sahneye_yonelen("Game04");
        }
    }
    public void Lvl_5()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 5)
        {
            sahneye_yonelen("Game05");
        }
    }
    public void Lvl_6()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 6)
        {
            sahneye_yonelen("Game06");
        }
    }
    public void Lvl_7()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 7)
        {
            sahneye_yonelen("Game07");
        }
    }
    public void Lvl_8()
    {
        if (PlayerPrefs.GetInt(LVLL) >= 8)
        {
            sahneye_yonelen("Game08");
        }
    }
    public void Lvlss()
    {
        sahneye_yonelen("ZZZ_Lvls");
    }
}
