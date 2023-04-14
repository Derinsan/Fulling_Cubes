using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PosX
{
    [SerializeField] private float _speedPlayer;

    private void Update()
    {
        if (PlayerState._isPlayerDead == false)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            
                transform.Translate(touchDeltaPosition.x * _speedPlayer, 0, 0);
            }
            ControllObject();
        }
    }
}
