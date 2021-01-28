using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    static MusicControl muzikOynatici;

    private void Awake()
    {
        if (muzikOynatici != null)
        {
            Destroy(gameObject);
        }
        else
        {
            muzikOynatici = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
