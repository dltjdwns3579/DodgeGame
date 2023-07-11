using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Enemy enemy;
    public GameObject enemyGroup;
    public bool isPlaing = true;
    public int spawnPercent = 5;

    public Text text;
    public float timer = 0f;

    public GameObject restartBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaing == false)
        {
            restartBtn.SetActive(true);
        }
        isPlaing = !FindAnyObjectByType<Player>().isGameover;
        if (isPlaing)
        {
            timer += Time.deltaTime;
            text.text = timer.ToString("N2");
            int rand = Random.Range(0, 101);
            if(rand<= spawnPercent)
            {
                int zone = Random.Range(0, 4);
                Enemy e = Instantiate(enemy);
                float posX = 0;
                float posY = 0;
                switch (zone)
                {
                    case 0:
                        e.posY = -1;
                        e.transform.position = new Vector3(Random.Range(-8.3f, 8.3f), 4.7f);
                        break;
                    case 1:
                        e.posX = -1;
                        e.transform.position = new Vector3(8.3f, Random.Range(-4.7f, 4.7f));
                        break;
                    case 2:
                        e.posY = 1;
                        e.transform.position = new Vector3(Random.Range(-8.3f, 8.3f), -4.7f);
                        break;
                    case 3:
                        e.posX = 1;
                        e.transform.position = new Vector3(-8.3f, Random.Range(-4.7f, 4.7f));
                        break;
                }
            }
        }
    }
}
