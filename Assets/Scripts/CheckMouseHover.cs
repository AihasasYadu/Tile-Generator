using UnityEngine;
using System.Collections;
using TMPro;

public class CheckMouseHover : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currenTileText;

    private const int CUBE_LAYER = 8;
    private Ray ray;
    private RaycastHit hit;
    private void Update()
    {
        CheckMouse();
    }

    private void CheckMouse()
    {
        string tileLocation;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.layer.Equals(CUBE_LAYER))
        {
            tileLocation = hit.collider.GetComponent<TileInfo>().location;
            currenTileText.SetText(tileLocation);
        }
    }
}