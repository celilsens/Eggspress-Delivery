using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MaskTransitions;

public class WinPopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TimerUI _timerUI;
    [SerializeField] Button _doBetterButton;
    [SerializeField] Button _mainMenuButton;
    [SerializeField] TMP_Text _timerText;

    private void OnEnable()
    {
        _timerText.text = _timerUI.GetFinalTime();
        _doBetterButton.onClick.AddListener(OnDoBetterButtonClicked);

        _mainMenuButton.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadLevel(Consts.SceneNames.MENU_SCENE, 0.25f);
        });
    }

    private void OnDoBetterButtonClicked()
    {
        TransitionManager.Instance.LoadLevel(Consts.SceneNames.GAME_SCENE, 0.25f);
    }
}
