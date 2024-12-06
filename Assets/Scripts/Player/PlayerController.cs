using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private IPlayerState _curState;

    public PlayerIdleState PlayerIdleState { get; private set; }
    public PlayerWalkState PlayerWalkState { get; private set; }
    public PlayerRunState PlayerRunState { get; private set; }
    public PlayerMeleeAttackState PlayerMeleeAttackState { get; private set; }
    public PlayerRangeAttackState playerRangeAttackState { get; private set; }
    public PlayerHitState playerHitState { get; private set; }
    public PlayerDeadState playerDeadState { get; private set; }

    private void Awake()
    {
        PlayerIdleState = new PlayerIdleState(this);
        PlayerWalkState = new PlayerWalkState(this);
        PlayerRunState = new PlayerRunState(this);
        PlayerMeleeAttackState = new PlayerMeleeAttackState(this);
        playerRangeAttackState = new PlayerRangeAttackState(this);
        playerHitState = new PlayerHitState(this);
        playerDeadState = new PlayerDeadState(this);
    }

    private void Start()
    {
        ChangeState(PlayerIdleState);   
    }

    private void Update()
    {
        _curState?.OnUpdate();    
    }

    private void FixedUpdate()
    {
        _curState?.OnFixedUpdate();
    }

    public void ChangeState(IPlayerState newState)
    {
        _curState?.Exit();
        _curState = newState;
        _curState.Enter();
    }
}
