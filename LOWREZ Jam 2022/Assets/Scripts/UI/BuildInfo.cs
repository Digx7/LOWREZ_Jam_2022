using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildInfo : MonoBehaviour
{
  public TextMeshProUGUI TextObject;

  public void Start(){
    string output = "" + Application.companyName + "\n" + Application.version;
    TextObject.text = output;
  }
}
