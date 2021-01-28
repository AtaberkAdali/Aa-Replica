using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lvl5;
    public GameObject lvl6;
    public GameObject lvl7;
    public GameObject lvl8;
    const string LVLL = "Lvll_Last";
    private int skl = 0;
    void Start()
    {
        Debug.Log("skl: " + PlayerPrefs.GetInt(LVLL));
        skl = PlayerPrefs.GetInt(LVLL);
        if (skl == 8)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
        }
        else if (skl == 7)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
        else if (skl == 6)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
        }
        else if (skl == 5)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
        }
        else if (skl == 4)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
        }
        else if (skl == 3)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(false);
        }
        else if (skl == 2)
        {
            lvl2.SetActive(false);
        }
    }
}
