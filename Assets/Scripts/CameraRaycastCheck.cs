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
            //canvas.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //if(hit.collider.tag != "Untagged")
            //    Debug.Log("Namierzono: " + hit.collider.tag);

            if (Input.GetMouseButtonDown(0))
            {
                canvas.gameObject.SetActive(true);
                canvasAnimations.ShowCanvas();
            }

            if (Input.GetMouseButtonDown(1))
            {
                canvasAnimations.HideCanvas();
            }
        }

    }
}
