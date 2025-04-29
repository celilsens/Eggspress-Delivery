using DG.Tweening;
using MaskTransitions;
using UnityEngine;
using UnityEngine.UI;

public class MenuControllerUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _blackBackgroundObject;
    [SerializeField] private GameObject _howToPlayPopupObject;
    [SerializeField] private GameObject _storyPopupObject;

    [Header("Buttons")]
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _howToPlayButton;
    [SerializeField] private Button _gotItButton;
    [SerializeField] private Button _theStoryButton;
    [SerializeField] private Button _coolStoryButton;
    [SerializeField] private Button _quitButton;

    [Header("Settings")]
    [SerializeField] private float _animationDuration;

    private Image _blackBackgroundImage;
    private void Awake()
    {
        _blackBackgroundImage = _blackBackgroundObject.GetComponent<Image>();
        _playButton.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadLevel(Consts.SceneNames.GAME_SCENE, 0.25f);
            AudioManager.Instance.Play(SoundType.TransitionSound);
        });

        _howToPlayButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.TransitionSound);
            _howToPlayPopupObject.SetActive(true);
            _blackBackgroundObject.SetActive(true);

            _blackBackgroundImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
            _howToPlayPopupObject.transform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);

        });

        _gotItButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.TransitionSound);
            _blackBackgroundImage.DOFade(0f, _animationDuration).SetEase(Ease.Linear);
            _howToPlayPopupObject.transform.DOScale(0f, _animationDuration).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                _storyPopupObject.SetActive(false);
                _blackBackgroundObject.SetActive(false);
            });
        });

        _theStoryButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.TransitionSound);
            _storyPopupObject.SetActive(true);
            _blackBackgroundObject.SetActive(true);

            _blackBackgroundImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
            _storyPopupObject.transform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);
        });

        _coolStoryButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.TransitionSound);
            _blackBackgroundImage.DOFade(0f, _animationDuration).SetEase(Ease.Linear);
            _storyPopupObject.transform.DOScale(0f, _animationDuration).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                _storyPopupObject.SetActive(false);
                _blackBackgroundObject.SetActive(false);
            });
        });

        _quitButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.ButtonClickSound);
            Application.Quit();
        });
    }
}
