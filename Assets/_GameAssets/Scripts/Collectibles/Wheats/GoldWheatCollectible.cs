using UnityEngine;

public class GoldWheatCollectible : MonoBehaviour
{
    [SerializeField] private PlayerController _playerControler;
    [SerializeField] private float _movementIncreaseSpeed;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerControler.SetMovementSpeed(_movementIncreaseSpeed, _resetBoostDuration);
        Destroy(gameObject);
    }
}
