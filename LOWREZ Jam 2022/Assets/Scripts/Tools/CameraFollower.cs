using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameData_Vector2Int_SO playerPos;
    public Vector2 bounds;

    private Vector2 workingBounds;

    [SerializeField]
    protected TileMapManager tileMapManager;

    public void Awake(){
      tileMapManager = GameObject.Find("TileMapManager").GetComponent<TileMapManager>();
    }



    private void MoveCamera(){

    }

    private void UpdateWorkingBounds(){
      workingBounds = (Vector2)this.transform.position + bounds;
    }

    private bool isPlayerOutOfBounds(){
      UpdateWorkingBounds();
      if(playerPos.data.x > workingBounds.x || playerPos.data.x < -workingBounds.x) return false;
      if(playerPos.data.y > workingBounds.y || playerPos.data.y < -workingBounds.y) return false;
      else return true;
    }
}
