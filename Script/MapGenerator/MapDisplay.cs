using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    //public enum DrawMode { NoiseMap, ColourMap};
    //public DrawMode drawMode;

    //[SerializeField]
    //private Renderer textureRenderer;
    //public int XSize;
    //public int YSize;
    //public float noiseScale;

    //public int octaves;
    //[Range(0,1)]
    //public float persistance;
    //public float lacunarity;

    //public int seed;
    //public Vector2 offset;

    //public bool autoUpdata;

    //public TerrainType[] region;
    //public void GenerateNoiseMap()
    //{
    //    float[,] noiseMap = NoiseMapGenerator.NoiseMap(XSize, YSize, seed, noiseScale, octaves, persistance, lacunarity, offset);

    //    Color[] colourMap = new Color[XSize * YSize];
    //    for (int y = 0; y < YSize; y++)
    //    {
    //        for (int x = 0; x < XSize; x++)
    //        {
    //            float currentHeight = noiseMap[x, y];
    //            for(int i = 0; i < region.Length; i++)
    //            {
    //                if (currentHeight <= region[i].height)
    //                {
    //                    colourMap[y * YSize + x] = region[i].colour;
    //                    break;
    //                }
    //            }
    //        }
    //    }
    //    if(drawMode == DrawMode.NoiseMap)
    //        DrawTexture(TextureGenerator.TextureFromHeightMap(noiseMap));
    //    else if(drawMode == DrawMode.ColourMap)
    //    {
    //        DrawTexture(TextureGenerator.TextureFromColourMap(colourMap,XSize,YSize));
    //    }

    //}
    //public void DrawTexture(Texture2D texture)
    //{

    //        textureRenderer.sharedMaterial.mainTexture = texture;
    //        textureRenderer.transform.localScale = new Vector3(texture.width, texture.height, texture.height);
        
    //}
    //[System.Serializable]
    //public struct TerrainType
    //{
    //    public string name;
    //    public float height;
    //    public Color colour;
    //}
    //private void OnValidate()
    //{
    //    if (XSize < 1)
    //        XSize = 1;
    //    if (YSize < 1)
    //        YSize = 1;
    //    if (lacunarity < 1)
    //        lacunarity = 1;
    //    if (octaves < 0)
    //        octaves = 0;
    //}
}
