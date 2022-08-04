using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : TileMovement
{
  public override void Input(Vector2Int direction){
    Vector3Int realDirection = (Vector3Int)direction;
    Vector3Int pos = GetGridPos();
    Vector3Int destination = pos + realDirection;

    //Debug.Log("PlayerMovement Input Data\nrealDirection: " + realDirection + "| pos: " + pos + "| destination: " + destination);

    if(tileMapManager.isValidTile(destination)) Move(destination);
  }
}
