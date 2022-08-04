using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameData_Vector2Int", menuName = "ScriptableObjects/GameData/Vector2Int", order = 1)]
public class GameData_Vector2Int_SO : ScriptableObject
{
    public Vector2Int data;

    public Vector2Int GetData(){
      return data;
    }

    public void SetData(Vector2Int input){
      data = input;
    }
}
