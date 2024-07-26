using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="New Description", menuName = "Objects Data")]
public class ObjectData : ScriptableObject
{
    public string title;
    public string description;
    public Sprite sprite;

    public UnityEvent OnSelect;
}
