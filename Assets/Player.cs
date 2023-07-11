using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   public bool isGameover = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "finish") ;
        {
            Time.timeScale = 0;
            isGameover = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float poxX = 0;
        float posY = 0;
        if (Input.GetKey(KeyCode.A))
        {
            poxX -= 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            posY -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            poxX += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            posY += 1;
        }
        transform.position = new Vector3(transform.position.x + poxX *
            Time.deltaTime * 10, transform.position.y + posY * Time.deltaTime * 15);

        Vector3 pos = transform.position;
        if (pos.x < -8.3f)
        {
            pos.x = -8.3f;
        }
        else if (pos.x > 8.3f)
        {
            pos.x = 8.3f;
        }

        if (pos.y < -4.7f)
        {
            pos.y = -4.7f;
        }
        else if (pos.y > 4.7f)
        {
            pos.y = 4.7f;
        }
        transform.position = pos;
    }
}
