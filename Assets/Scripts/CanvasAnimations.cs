using DG.Tweening;
using UnityEngine;

public class CanvasAnimations : MonoBehaviour
{
    [SerializeField] private RectTransform _description, _title;
    [SerializeField] private float _cycleLength = 2;
    [SerializeField] public Vector2 descriptionOpenVector, titleOpenVector;

    void Start()
    {

    }

    public void ShowCanvas()
    {
        _description.DOAnchorPos(descriptionOpenVector, _cycleLength);
        _title.DOAnchorPos(titleOpenVector, _cycleLength);
    }
    public void HideCanvas()
    {
        _description.DOAnchorPos(descriptionOpenVector *-1, _cycleLength);
        _title.DOAnchorPos(titleOpenVector *-1, _cycleLength);
    }
}
