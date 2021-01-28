using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuYavascaGoster : MonoBehaviour
{
    public float yavascaGostermeSuresi;
    private Color guncelRenk = Color.black;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad < yavascaGostermeSuresi)
        {
            float alfaDegisimi = Time.deltaTime / yavascaGostermeSuresi;
            guncelRenk.a -= alfaDegisimi;
            GetComponent<Image>().color = guncelRenk;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
