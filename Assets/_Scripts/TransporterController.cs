using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransporterController : MonoBehaviour
{
    public string destination;

    public void ChangeScene()
    {
        SceneManager.LoadScene(destination);
    }
}
