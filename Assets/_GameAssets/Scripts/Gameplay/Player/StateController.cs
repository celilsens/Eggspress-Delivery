using UnityEngine;

public class StateController : MonoBehaviour
{
    private PlayerState _currentPlayerStaate = PlayerState.Idle;

    private void Start()
    {
        ChangeState(PlayerState.Idle);
    }

    public void ChangeState(PlayerState newPlayerState)
    {
        if (_currentPlayerStaate == newPlayerState) { return; }
        _currentPlayerStaate = newPlayerState;
    }
    
    public PlayerState GetCurrentState()
    {
        return _currentPlayerStaate;
    }
}
