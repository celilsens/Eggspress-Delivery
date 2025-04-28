using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverContoller : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.Instance.Play(SoundType.ButtonHoverSound);
    }
}
