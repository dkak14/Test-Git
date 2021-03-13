using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainTile : TileBase
{
    public override void SearchSurroundTileOnCreatMap2()
    {
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        List<TileBase> tileList = new List<TileBase>();
        for (int X = x - 2; X <= x + 2; X++)
        {
            for (int Y = y - 2; Y <= y + 2; Y++)
            {
                Vector2Int Pos = new Vector2Int(X, Y);
                tileList.Add(MapManager.Instance.GetTiletoPosition(Pos));
            }
        }
        int Mountain2Count = 0;
        for (int i = 0; i < tileList.Count; i++)
        {
            if (tileList[i] == null)
            {
                continue;
            }


            if (tileList[i].TileID == 4 || tileList[i].TileID == 3)
                Mountain2Count++;
        }

        if (Mountain2Count > 20)
        {
            TileBase tile = TileDataManager.Instance.GetTileData("Mountain2");
            Vector2Int Pos = new Vector2Int((int)transform.position.x, (int)transform.position.y);
            MapManager.Instance.TileChange(Pos, tile);
            return;
        }

    }
}
