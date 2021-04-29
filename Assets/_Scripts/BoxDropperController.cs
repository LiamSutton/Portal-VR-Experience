using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDropperController : MonoBehaviour
{
    public GameObject boxDropperLid;

    public void DropBox()
    {
        boxDropperLid.SetActive(false);
    }
}
