using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class InteriorRoomTile : RuleTile<InteriorRoomTile.Neighbor>
{
    public class Neighbor : RuleTile.TilingRule.Neighbor
	{
        public const int Null = 3;
        public const int NotNull = 4;
    }

    public override bool RuleMatch(int neighbor, TileBase tile)
	{
        switch (neighbor)
		{
            case Neighbor.Null: return tile == null;
            case Neighbor.NotNull: return tile != null;
			case Neighbor.This: return tile != null && tile.GetType() == typeof(InteriorRoomTile);
			case Neighbor.NotThis: return tile == null || tile.GetType() != typeof(InteriorRoomTile);
		}
        return base.RuleMatch(neighbor, tile);
    }
}
