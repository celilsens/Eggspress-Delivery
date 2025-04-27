using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    }

    private void OnDoBetterButtonClicked()
    {
        SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
    }
}
