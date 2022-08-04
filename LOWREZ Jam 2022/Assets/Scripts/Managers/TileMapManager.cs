using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapManager : MonoBehaviour
{
  [SerializeField]
  private Tilemap ground;
  [SerializeField]
  private Tilemap collision;
  [SerializeField]
  private Grid grid;

  private float xOffset;
  private float yOffset;

  public void Awake(){
    Vector3 size = grid.cellSize;
    xOffset = size.x/2;
    yOffset = size.y/2;
  }

  public bool isValidTile(Vector3Int position){
    if(!ground.HasTile(position) || collision.HasTile(position))
      return false;
    return true;
  }

  public bool isValidTile(Vector2Int position){
    return isValidTile(ground.WorldToCell((Vector3Int)position));
  }

  public Vector3 CellToWorld(Vector2Int position){
    Vector3 newPos = grid.CellToWorld((Vector3Int) position);
    newPos.x += xOffset;
    newPos.y += yOffset;
    return newPos;
  }

  public Vector3 CellToWorld(Vector3Int position){
    Vector3 newPos = grid.CellToWorld(position);
    newPos.x += xOffset;
    newPos.y += yOffset;
    return newPos;
  }

  public Vector3Int NearestCell(Vector3 startingPosition){
    return grid.WorldToCell(startingPosition);
  }
}
