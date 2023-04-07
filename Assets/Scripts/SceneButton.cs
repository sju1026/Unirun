using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public int target_scene = 0;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("버튼눌림");
        SceneManager.LoadScene(target_scene, LoadSceneMode.Single);
    }
}
