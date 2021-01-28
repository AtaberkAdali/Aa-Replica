using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PinMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private bool isPin = false;
    public GameObject myRod;
    public int Winn=3;
    public static int PinOnTheBall=0;
    private bool oneTime = true;
    private bool oneTimee = true;
    private bool oneTimeee = true;
    public float kacSnyBekle;
    public float kacSnyBeklee;
    public int howManyy;//spawncontroldeki howManyden bir fazlasını yaz.
    private PasueControl MyPause;
    [SerializeField] AudioClip WinMusic;
    [SerializeField] AudioClip LoseMusic;
    private void Start()
    {
        MyPause = GameObject.FindObjectOfType<PasueControl>();
        kacSnyBekle = 0.9f;
        kacSnyBeklee = 0.95f;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isPin)
            {
                Vector3 pinMove = rb.velocity;
                pinMove.y += moveSpeed;
                rb.velocity = pinMove;
            }
        }
        if (PinOnTheBall == howManyy)
        {
            Winn = 1;
            Time.timeScale = 0.2f;
            if (oneTimee)
            {
                AudioSource.PlayClipAtPoint(WinMusic, transform.position);
                oneTimee = false;
            }
        }
        if (MyPause.Restle)
        {
            PinOnTheBall = 0;
            MyPause.Restle = false;
        }
        if (Winn == 1)
        {
            kacSnyBeklee -= Time.deltaTime;
        }
        if (kacSnyBeklee <= 0.3)
        {
            Time.timeScale = 1;
        }
        if (kacSnyBeklee <= 0)
        {
            PinOnTheBall = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        if (Winn==0)
        {
            kacSnyBekle -= Time.deltaTime;
        }
        if (kacSnyBekle <= 0.3)
        {
            Time.timeScale = 1;
        }
        if (kacSnyBekle <= 0)
        {
            PinOnTheBall = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ball")
        {
            myRod.SetActive(true);
            transform.SetParent(collision.transform);
            isPin = true;
            if (oneTime)
            {
                PinOnTheBall++;
                oneTime = false;
            }
        }
        if (collision.tag == "pinn")
        {
            myRod.SetActive(true);
            Winn = 0;
            transform.SetParent(collision.transform);
            isPin = true;
            Time.timeScale = 0.2f;
            Debug.Log("lose");
            if (oneTimeee)
            {
                AudioSource.PlayClipAtPoint(LoseMusic, transform.position);
                oneTimeee = false;
            }
        }
    }
}
