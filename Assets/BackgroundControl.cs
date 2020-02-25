using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundControl : MonoBehaviour
{
    public GameObject Color;
    public PlayerMove Player;
    public Text Score;
    public int score;
    Color32 P = new Color32(139, 0, 255, 255);
    Color32 L = new Color32(169, 255, 0, 255);
    Color32 LB = new Color32(170, 103, 57, 255);
    Color32 T = new Color32(0, 126, 86, 255);
    Color32 M = new Color32(128, 122, 43, 255);

    public float secsBetweenChange = 5f;
    public int ColorPick;

    public AudioSource Point;
    public AudioSource Loss;

    public bool Round = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeColor", 5f, secsBetweenChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 9)
        {
            SceneManager.LoadScene("WinScene");
        }
        else if (score < -9)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    void ChangeColor()
    {
        ColorPick = Random.Range(0, 5);
        if (ColorPick == 0)
        {
            Player.red = false;
            Player.blue = false;
            Player.green = false;
            Player.yellow = false;
            Color.GetComponent<SpriteRenderer>().color = P;
            if (Player.red == true && Player.blue == true && Player.yellow == false && Player.green == false)
            {
                score++;
                Point.Play();
                Score.text = "Score: " + score;
            }
            else
            {
                score--;
                Loss.Play();
                Score.text = "Score: " + score;
            }
        }
        if (ColorPick == 1)
        {
            Player.red = false;
            Player.blue = false;
            Player.green = false;
            Player.yellow = false;
            Color.GetComponent<SpriteRenderer>().color =L;
            if (Player.yellow == true && Player.green == true && Player.red == false && Player.blue == false)
            {
                score++;
                Point.Play();
                Score.text = "Score: " + score;
            }
            else
            {
                score--;
                Loss.Play();
                Score.text = "Score: " + score;
            }
        }
        if (ColorPick == 2)
        {
            Player.red = false;
            Player.blue = false;
            Player.green = false;
            Player.yellow = false;
            Color.GetComponent<SpriteRenderer>().color = LB;
            if (Player.yellow == true && Player.green == false && Player.red == true && Player.blue == true)
            {
                score++;
                Point.Play();
                Score.text = "Score: " + score;
            }
            else
            {
                score--;
                Loss.Play();
                Score.text = "Score: " + score;
            }
        }
        if (ColorPick == 3)
        {
            Player.red = false;
            Player.blue = false;
            Player.green = false;
            Player.yellow = false;
            Color.GetComponent<SpriteRenderer>().color = T;
            if (Player.yellow == false && Player.green == true && Player.red == false && Player.blue == true)
            {
                score++;
                Point.Play();
                Score.text = "Score: " + score;
            }
            else
            {
                score--;
                Loss.Play();
                Score.text = "Score: " + score;
            }
        }
        if (ColorPick == 4)
        {
            Player.red = false;
            Player.blue = false;
            Player.green = false;
            Player.yellow = false;
            Color.GetComponent<SpriteRenderer>().color = M;
            if (Player.yellow == true && Player.green == true && Player.red == true && Player.blue == true)
            {
                score++;
                Point.Play();
                Score.text = "Score: " + score;
            }
            else
            {
                score--;
                Loss.Play();
                Score.text = "Score: " + score;
            }
        }


    }

    //purple (R/B) = 139, 0, 255
    //lime green (Y/G) = 169, 255, 0
    //Teal (G/B) = #007E56
    //light Brown (R/Y/B) = #AA6739
    //mustard (R/Y/B/G) = #807A2B
    //
}
