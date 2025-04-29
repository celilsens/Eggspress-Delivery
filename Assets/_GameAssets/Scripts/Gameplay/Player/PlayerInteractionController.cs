using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInteractionController : MonoBehaviour
{
    [SerializeField] private Transform _playerVisualTransform;

    private PlayerController _playerControler;
    private Rigidbody _playerRigidbody;

    void Awake()
    {
        _playerControler = GetComponent<PlayerController>();
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();
        BoxCollider eggCollider = other.GetComponent<BoxCollider>();
        eggCollider.enabled = false;
        collectible?.Collect();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<IBoostable>(out var boostable))
        {
            boostable.Boost(_playerControler);
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.TryGetComponent<IDamageable>(out var damageable))
        {
            damageable.GiveDamage(_playerRigidbody, _playerVisualTransform);
            CameraShake.Instance.ShakeCamera(1f, 0.5f);
        }
    }
}
