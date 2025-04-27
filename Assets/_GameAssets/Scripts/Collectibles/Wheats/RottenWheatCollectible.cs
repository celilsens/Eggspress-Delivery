using UnityEngine;
using UnityEngine.UI;

public class RottenWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private PlayerController _playerControler;
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerStateUI _playerStateUI;
    private RectTransform _playerBoosterTranform;
    private Image _playerBoosterImage;

    void Awake()
    {
        _playerBoosterTranform = _playerStateUI.GetBoosterSlowTransform;
        _playerBoosterImage = _playerBoosterTranform.GetComponent<Image>();
    }
    public void Collect()
    {
        _playerControler.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
        
        _playerStateUI.PlayerBoosterUIAnimations(_playerBoosterTranform, _playerBoosterImage, 
        _playerStateUI.GetRottenBoosterWheatImage, _wheatDesignSO.ActiveSprite, _wheatDesignSO.PassiveSprite, 
        _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveWheatSprite, _wheatDesignSO.ResetBoostDuration);

        Destroy(gameObject);
    }
}
