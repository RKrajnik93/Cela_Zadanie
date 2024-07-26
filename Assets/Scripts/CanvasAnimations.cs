using DG.Tweening;
using UnityEngine;

public class CanvasAnimations : MonoBehaviour
{
    [SerializeField] private RectTransform description, title;
    [SerializeField] private float cycleLength = 2;
    [SerializeField] public Vector2 descriptionOpenVector, titleOpenVector;

    public void ShowCanvas()
    {
        description.DOAnchorPos(descriptionOpenVector, cycleLength).SetEase(Ease.OutExpo);
        title.DOAnchorPos(titleOpenVector, cycleLength).SetEase(Ease.OutExpo);
    }
    public void HideCanvas()
    {
        description.DOAnchorPos(descriptionOpenVector *-1, cycleLength).SetEase(Ease.OutExpo);
        title.DOAnchorPos(titleOpenVector *-1, cycleLength).SetEase(Ease.OutExpo);
    }
}
