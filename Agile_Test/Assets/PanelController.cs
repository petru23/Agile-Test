using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour 
{
    private GameObject toControl;

    public void GeneratePrefab(GameObject toInstantiate)
    {
        toControl = Instantiate(toInstantiate);
     //   toControl.transform.position = Camera.main.WorldToScreenPoint(Input.mousePosition);
        toControl.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0f);
        toControl.AddComponent<PanelController>();
    }

    public void ControlPosition()
    {
        this.transform.position = Input.mousePosition;
    }
}
