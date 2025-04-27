using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{

    private PlayerController _playerControler;
    void Awake()
    {
        _playerControler = GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ICollectible>(out var collectible))
        {
            collectible.Collect();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent<IBoostable>(out var boostable)){
            boostable.Boost(_playerControler);
        }
    }
}
