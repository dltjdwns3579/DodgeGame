using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float posX;
    public float posY;

    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        speedX = Random.Range(5f, 10f);
        speedY = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + posX *
           Time.deltaTime * speedX, transform.position.y + posY * Time.deltaTime * speedY);
    }
}
