using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : TileBase
{
    public override void SearchSurroundTileOnCreatMap()
    {
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        List<TileBase> tileList = new List<TileBase>();
        for(int X = x - 2; X <= x + 2; X++)
        {
            for (int Y = y - 2; Y <= y + 2; Y++)
            {
                Vector2Int Pos = new Vector2Int(X, Y);
                tileList.Add(MapManager.Instance.GetTiletoPosition(Pos));
            }
        }
        int WaterCount = 0;
        int MountainCount = 0;
        int Mountain2Count = 0;
        for (int i = 0; i < tileList.Count; i ++)
        {
            if (tileList[i] == null)
            {
                WaterCount++;
                continue;
            }

            if (tileList[i].TileID == 0)
                WaterCount++;
            if (tileList[i].TileID == 4 || tileList[i].TileID == 3)
                Mountain2Count++;
            if (tileList[i].TileID == 1 || tileList[i].TileID == 3 || tileList[i].TileID == 4)
                MountainCount++;
        }
        if(WaterCount > 5)
        {
            TileBase tile = TileDataManager.Instance.GetTileData("Sand");
            Vector2Int Pos = new Vector2Int((int)transform.position.x, (int)transform.position.y);
            MapManager.Instance.TileChange(Pos, tile);
            return;
        }
        else if (Mountain2Count > 13)
        {
            TileBase tile = TileDataManager.Instance.GetTileData("Mountain2");
            Vector2Int Pos = new Vector2Int((int)transform.position.x, (int)transform.position.y);
            MapManager.Instance.TileChange(Pos, tile);
            return;
        }
        else if (MountainCount > 23)
        {
            TileBase tile = TileDataManager.Instance.GetTileData("Mountain");
            Vector2Int Pos = new Vector2Int((int)transform.position.x, (int)transform.position.y);
            MapManager.Instance.TileChange(Pos, tile);
            return; 
        }
    }
}
