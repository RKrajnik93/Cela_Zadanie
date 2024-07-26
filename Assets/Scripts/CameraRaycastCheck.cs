using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReyCast : MonoBehaviour
{
    public Canvas canvas;
    [SerializeField] CanvasAnimations canvasAnimations;

    private void Start()
    {
        if (canvas != null)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.CompareTag("SceneObject"))
                {
                    hit.collider.gameObject.GetComponent<ObjectControler>().SetSelected();
                }
                canvas.gameObject.SetActive(true);
                canvasAnimations.ShowCanvas();
            }
        }

    }
}
