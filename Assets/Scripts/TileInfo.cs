using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfo : MonoBehaviour
{
    private string type;
    [HideInInspector] public string location;

    private void Start()
    {
        type = "Land";
    }
}
