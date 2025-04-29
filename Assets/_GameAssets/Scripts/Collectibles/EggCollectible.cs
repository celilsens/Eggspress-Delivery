using System;
using System.Collections;
using UnityEngine;

public class EggCollectible : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        Destroy(gameObject);
        CameraShake.Instance.ShakeCamera(0.5f, 0.5f);
        AudioManager.Instance.Play(SoundType.PickupGoodSound);
        GameManager.Instance.OnEggCollected();
    }
}
