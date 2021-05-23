using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private BoxCollider cube;
    [SerializeField] private int rows,
                                 cols;
    [SerializeField] private Transform gridOrigin;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Vector3 spawnPos = new Vector3(i, 0, j) + gridOrigin.position; //directly using 'i' and 'j' cause I've set the default size of the cube as (1, 1, 1), so the next cube does not overlap with another
                BoxCollider temp = Instantiate(cube, spawnPos, Quaternion.identity);
                temp.GetComponent<TileInfo>().location = i + ", " + j;
            }
        }
    }
}
