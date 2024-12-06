using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadState : IPlayerState
{
    private PlayerController _playerController;
    public PlayerDeadState(PlayerController playerController)
    {
        this._playerController = playerController;
    }
    public void Enter()
    {

    }
    public void Exit()
    {

    }
    public void OnUpdate()
    {

    }
    public void OnFixedUpdate()
    {

    }
}
