using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    public Vector2IntEvent wasd;

    public void Update(){
      WASD();
    }

    public void WASD(){
      if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") ){
        Vector2Int output = new Vector2Int();
        if(Input.GetKeyDown("w")) output.y=1;
        if(Input.GetKeyDown("s")) output.y=-1;
        if(Input.GetKeyDown("d")) output.x=1;
        if(Input.GetKeyDown("a")) output.x=-1;

        //Debug.Log("WASD output: " + output);

        wasd.Invoke(output);
      }
    }
}
