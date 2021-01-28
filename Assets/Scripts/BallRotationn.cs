using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotationn : MonoBehaviour
{
    public float rotationSpeed;
    public bool SolaMi=false;
    public int KacinciLvl;
    const string LVLL = "Lvll_Last";
    public int SonKaldiginLvl=0;

    private void Start()
    {
        //playerpreferden lvlı al max lvl sayısından büyükse o sayıya eşitle (kaçıncı lvl sayısına)
        if (PlayerPrefs.GetInt(LVLL) < KacinciLvl)
        {
            PlayerPrefs.SetInt(LVLL, (KacinciLvl));
        }
        Debug.Log("LVL:" + PlayerPrefs.GetInt(LVLL));
        SonKaldiginLvl = PlayerPrefs.GetInt(LVLL);
    }
    void Update()
    {
        if (SolaMi)
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
    }
    
}
