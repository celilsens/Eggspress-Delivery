using UnityEngine;

public class SpatulaBooster1 : MonoBehaviour, IBoostable
{
    [Header("References")]
    [SerializeField] private Animator _spatulaAnimator;

    [Header("Settings")]
    [SerializeField] private float _jumpForce;
    
    private bool _isBActivated;
    public void Boost(PlayerController playerController)
    {
        if (_isBActivated) { return; }
        PlayBoostAnimation();
        Rigidbody playerRigidbody = playerController.GetPlayerRigidbody();

        playerRigidbody.linearVelocity = new Vector3(playerRigidbody.linearVelocity.x, 0f, playerRigidbody.linearVelocity.z);
        playerRigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        _isBActivated = true;
        Invoke(nameof(ResetActivation),0.2f);
    }
    private void PlayBoostAnimation()
    {
        _spatulaAnimator.SetTrigger(Consts.OtherAnimations.IS_SPATULA_JUMPING);
    }
    private void ResetActivation()
    {
        _isBActivated = false;
    }
}
