using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoissionDiscSampling : MonoBehaviour
{
    List<Vector2> PoissionPoint = new List<Vector2>();
    List<Vector2> ActiveGrid = new List<Vector2>();
    Vector2[,] grid;
    void poission(float radius, Vector2 Pos)
    {
        float w = radius / Mathf.Sqrt(2);
        float radius2 = 2 * radius;
        int[,] mapFlags = MapManager.Instance.GetMapSize();
        float width = MapManager.Instance.MapWidth;
        float height = MapManager.Instance.MapWidth;
        grid = new Vector2[Mathf.CeilToInt(width / w), Mathf.CeilToInt(height / w)];
        Vector2 startPos = new Vector2(Random.Range(0, MapManager.Instance.MapWidth)/ w, MapManager.Instance.MapWidth / w);
        ActiveGrid.Add(startPos);
    }
    void poission2()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
