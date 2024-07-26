using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Canvas canvas;
    [SerializeField] CanvasAnimations canvasAnimations;
    [SerializeField] private Button closeButton, cubeBtn, capsuleBtn , sphereBtn;
    [SerializeField] private ObjectData cubeData, capsuleData, sphereData;
    [SerializeField] private Text titlePanel; 
    [SerializeField] private TextMeshProUGUI scrollViewText;
    [SerializeField] private Image descriptionImage;

    private void OnEnable()
    {
        closeButton.onClick.AddListener(CloseButtonOnClick);
        cubeBtn.onClick.AddListener(() => { SetupUI(cubeData.title, cubeData.description, cubeData.sprite, cubeBtn.image); });
        capsuleBtn.onClick.AddListener(() => { SetupUI(capsuleData.title, capsuleData.description, capsuleData.sprite, capsuleBtn.image); });
        sphereBtn.onClick.AddListener(() => { SetupUI(sphereData.title, sphereData.description, sphereData.sprite, sphereBtn.image); });
        cubeData.OnSelect.AddListener(() => { SetupUI(cubeData.title, cubeData.description, cubeData.sprite, cubeBtn.image); });
        capsuleData.OnSelect.AddListener(() => { SetupUI(capsuleData.title, capsuleData.description, capsuleData.sprite, capsuleBtn.image); });
        sphereData.OnSelect.AddListener(() => { SetupUI(sphereData.title, sphereData.description, sphereData.sprite, sphereBtn.image); });
    }

    private void OnDisable()
    {
        closeButton.onClick.RemoveListener(CloseButtonOnClick);
    }

    void CloseButtonOnClick()
    {
        canvasAnimations.HideCanvas();
    }

    public void SetupUI(string title, string description, Sprite descriptionSprite, Image buttonImage)
    {
        cubeBtn.image.color = capsuleBtn.image.color = sphereBtn.image.color = Color.white;

        buttonImage.color = Color.green;
        ChangeTitle(title);
        ChangeDescription(description);
        ChangeDescriptionImage(descriptionSprite);
    }

    void ChangeTitle(string titel)
    {
        titlePanel.text = titel;
    }
    void ChangeDescription(string description)
    {
        scrollViewText.text = description;
    }

    void ChangeDescriptionImage(Sprite sprite)
    {
        descriptionImage.sprite = sprite;
    }
}
