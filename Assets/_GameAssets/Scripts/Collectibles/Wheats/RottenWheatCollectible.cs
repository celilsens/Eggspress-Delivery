using UnityEngine;

public class RottenWheatCollectible : MonoBehaviour
{
    [SerializeField] private PlayerController _playerControler;
    [SerializeField] private float _movementDecreaseSpeed;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerControler.SetMovementSpeed(_movementDecreaseSpeed, _resetBoostDuration);
        Destroy(gameObject);
    }
}
