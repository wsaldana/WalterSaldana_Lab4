using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
    public void changeScene() {
        SceneManager.LoadScene(1);
    }
}
