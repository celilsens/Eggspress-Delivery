using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosePopup : MonoBehaviour
{
[Header("References")]
    [SerializeField] TimerUI _timerUI;
    [SerializeField] Button _tryAgainButton;
    [SerializeField] Button _mainMenuButton;
    [SerializeField] TMP_Text _timerText;

    private void OnEnable()
    {
        _timerText.text = _timerUI.GetFinalTime();
        _tryAgainButton.onClick.AddListener(OnTryAgainButtonClicked);
    }

    private void OnTryAgainButtonClicked()
    {
        SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
    }
}
