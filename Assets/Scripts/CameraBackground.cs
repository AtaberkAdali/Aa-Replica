using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraBackground : MonoBehaviour
{
    public Camera cm;
    private int pinmmm;
    public float UpSpeed;
    public float FocusSpeed;
    private float CurrentS=0f;
    private float CurrentF=0f;
    private bool FinishMi=false;
    public Text HowManyPinTextt;
    private bool StartMi = false;
    public int ballTransPoz;
    private void Awake()
    {
        cm = Camera.main;
        cm.orthographicSize = 0f;
        Vector3 cmTranss = cm.transform.position;
        cmTranss.y = ballTransPoz;
        cm.transform.position = cmTranss;
    }
    private void Start()
    {
        StartMi = true;
    }
    void Update()
    {
        pinmmm = GameObject.FindObjectOfType<PinMovement>().Winn;
        if (pinmmm == 0)
        {
            cm.backgroundColor = (Color.red);
            FinishMi = true;
        }
        else if (pinmmm == 1)
        {
            cm.backgroundColor = (Color.green);
            FinishMi = true;
        }
        if (FinishMi)
        {
            FinishEffect();
        }
        if (StartMi)
        {
            if (transform.position.y >= 0)
            {
                Vector3 cmTranss = cm.transform.position;
                cmTranss.y -= UpSpeed * Time.deltaTime/10;
                cm.transform.position = cmTranss;
            }
            if (cm.orthographicSize <= 5)
            {
                CurrentS += Time.deltaTime * FocusSpeed/5;
                cm.orthographicSize = CurrentS;
            }
            else
            {
                StartMi = false;
            }
        }
    }
    void FinishEffect()
    {
        HowManyPinTextt.text = " ";
        if (transform.position.y <= ballTransPoz)
        {
            Vector3 cmTrans = cm.transform.position;
            cmTrans.y += UpSpeed*Time.deltaTime;
            cm.transform.position = cmTrans;
        }
        if(cm.orthographicSize >= 0)
        {
            CurrentF += Time.deltaTime * FocusSpeed;
            cm.orthographicSize = (5 - CurrentF);
        }
    }
}
