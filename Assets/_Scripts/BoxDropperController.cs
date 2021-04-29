using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDropperController : MonoBehaviour
{
    GameObject boxDropperLid;

    public void DropBox()
    {
        boxDropperLid.SetActive(false);
    }
}
