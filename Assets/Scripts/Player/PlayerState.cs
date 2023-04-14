using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public static bool _isPlayerDead;
    [SerializeField] private GameObject _textOverGame;
    [SerializeField] private Text _scoreText;
    public static int _score;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _isPlayerDead = false;
        _textOverGame.SetActive(false);
        _score = 0;
    }

    private void Update()
    {
        _scoreText.text = $"{_score}";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            _isPlayerDead = true;
            _textOverGame.SetActive(true);
        }
    }
}
