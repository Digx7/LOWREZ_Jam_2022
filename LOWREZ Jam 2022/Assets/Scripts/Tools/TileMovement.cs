using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    public Vector2IntEvent OnPosChange;

    [SerializeField]
    protected TileMapManager tileMapManager;

    private Vector3Int currentGridPos;

    public void Awake(){
      tileMapManager = GameObject.Find("TileMapManager").GetComponent<TileMapManager>();
    }

    public void Start(){
      SnapToNearestCell();
      GetGridPos();
    }

    public virtual void Input(Vector2Int destination){
      Input((Vector3Int) destination);
    }

    public virtual void Input(Vector3Int destination){
      if(tileMapManager.isValidTile(destination)) Move(destination);
    }

    protected virtual void Move(Vector3Int destination){
      this.transform.position = tileMapManager.CellToWorld((Vector3Int) destination);
      GetGridPos();
    }

    protected virtual void SnapToNearestCell(){
      Vector3Int nearestCell = tileMapManager.NearestCell(this.transform.position);
      Input(nearestCell);
    }

    protected Vector3Int GetGridPos(){
      currentGridPos = tileMapManager.NearestCell(this.transform.position);

      OnPosChange.Invoke((Vector2Int)currentGridPos);

      return currentGridPos;
    }
}
