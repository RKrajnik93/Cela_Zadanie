using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControler : MonoBehaviour
{
    [SerializeField] private ObjectData objectData;

    public void SetSelected()
    {
        objectData.OnSelect?.Invoke();
    }
}
