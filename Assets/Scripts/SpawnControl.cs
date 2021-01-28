using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnControl : MonoBehaviour
{
    public int howMany;
    public GameObject Pin;
    public float defaultWaitTime = 2f;
    public float waitTime = -2f;
    private bool caniWait = false;
    public Text HowManyPinText;
    //public int HowManyPinValue;

    private void Start()
    {
        HowManyPinText.text = (howMany+1).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (howMany > 0)
            {
                if (!caniWait)
                {
                    caniWait = true;
                }
            }
            
        }
        
        if (caniWait)
        {
            waitTime -= Time.deltaTime;
        }
        if(waitTime <= 0)
        {
            caniWait = false;
            waitTime = defaultWaitTime;
            Spawnn();
        }
    }
    void Spawnn()
    {
        Instantiate(Pin, transform.position, transform.rotation);
        howMany--;
        HowManyPinText.text = (howMany+1).ToString();
    }
}
