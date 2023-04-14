using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstaclesCube : MonoBehaviour
{
    [SerializeField] private float _speedCube;
    [SerializeField] private float _speedRotateCube;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeColor(Random.Range(0f, 1f));
        _speedRotateCube = Random.Range(-3f, 3f);
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void ChangeColor(float t)
    {
        _spriteRenderer.color = Color.Lerp(Color.magenta, Color.blue, t);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, _speedRotateCube);
        transform.position += Vector3.down * _speedCube;

        if (PlayerState._isPlayerDead == true)
        {
            Destroy(gameObject);
        }

        if (transform.localScale == new Vector3(0.01999998f, 0.01999998f, 0.01999998f))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ScorePlus"))
        {
            PlayerState._score++;
            StartCoroutine(DecreaseCube());
        }
    }

    IEnumerator DecreaseCube()
    {
        for (float q = 0.5f; q >= 0.001f; q -= 0.03f)
        {
            transform.localScale = new Vector3(q, q, q);
            yield return new WaitForSeconds(0.03f);
        }
    }
}
