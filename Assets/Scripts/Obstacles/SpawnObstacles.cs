using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _cube;
    bool trigtime = false;
    [SerializeField] private float speedreset = 1f;
    float timer, x;
    private int i = 0;

    void Start()
    {
        timer = speedreset;
    }

    void Update()
    {
        if (PlayerState._isPlayerDead == false)
        {
            if (timer < 0)
            {
                timer = speedreset;
                trigtime = false;
            }
            if (timer == speedreset)
            {
                if (i == 0)
                {
                    x = Random.Range(-2f, 2f);//Задаем местоположение
                    i = 1;
                }
                else if (i == 1)
                {
                    x = _player.transform.position.x;
                    i = 0;
                }
                Instantiate(_cube, new Vector2(x, 6f), transform.rotation);//Генерация противника из префаба
                trigtime = true;
            }
            if (trigtime == true)
            {
                timer = timer - Time.deltaTime;
            }
        }
    }
}
