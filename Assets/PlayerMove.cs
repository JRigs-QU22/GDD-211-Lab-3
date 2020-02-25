using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Sprite;
    public bool red = false;
    public bool blue = false;
    public bool green = false;
    public bool yellow = false;
    Color32 Red = new Color32(255, 0, 0, 255);
    Color32 Green = new Color32(0, 255, 0, 255);
    Color32 Blue = new Color32(0, 0, 255, 255);
    Color32 Yellow = new Color32(255, 255, 0, 255);
    public RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 100f);
            //Debug.Log("GO LEFT");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * -100f);
            //Debug.Log("GO RIGHT");
        }

        

        if (Input.GetKey(KeyCode.Space))
        {
            hit = Physics2D.Raycast(transform.position, transform.up);
            Debug.DrawRay(transform.position, transform.up * 100f, Color.green);
        }
        else
        {
            hit = Physics2D.Raycast(transform.up, transform.position); 
            
        }
        

        if (hit)
        {
            Cube hitEnemy = hit.collider.GetComponent<Cube>();
            if (hitEnemy)
            {
                Sprite.GetComponent<SpriteRenderer>().color = hitEnemy.Sprite.color;
                Debug.DrawLine(transform.position, hit.point, Sprite.GetComponent<SpriteRenderer>().color);
            }
            

        }

        if (Sprite.GetComponent<SpriteRenderer>().color == Red)
        {
            red = true;
            Debug.Log("Red");
        }
        if (Sprite.GetComponent<SpriteRenderer>().color == Blue)
        {
            blue = true;
        }
        if (Sprite.GetComponent<SpriteRenderer>().color == Green)
        {
            green = true;
        }
        if (Sprite.GetComponent<SpriteRenderer>().color == Yellow)
        {
            yellow = true;
        }
    }
}
