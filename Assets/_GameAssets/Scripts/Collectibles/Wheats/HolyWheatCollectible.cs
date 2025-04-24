using UnityEngine;

public class HolyWheatCollectible : MonoBehaviour
{
    [SerializeField] private PlayerController _playerControler;
    [SerializeField] private float _forceIncrease;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerControler.SetJumpForce(_forceIncrease, _resetBoostDuration);
        Destroy(gameObject);
    }
}
