using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private RectTransform _timerRotatableTransform;
    [SerializeField] private TMP_Text _timerText;

    [Header("Settings")]
    [SerializeField] private float _rotationDuration = 60;
    [SerializeField] private Ease _rotationEase;


    private float _elapsedTime;
    private void Start()
    {
        PlayRotationAnimation();
        StartTimer();
    }
    private void PlayRotationAnimation()
    {
        _timerRotatableTransform.DORotate(new Vector3(0f, 0f, -360), _rotationDuration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(_rotationEase);
    }

    private void StartTimer()
    {
        _elapsedTime = 0;
        InvokeRepeating(nameof(UpdateTimerUI),0f,1f);
    }

    private void UpdateTimerUI()
    {
        _elapsedTime++;
        int minutes = Mathf.FloorToInt(_elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(_elapsedTime % 60f);

        _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
