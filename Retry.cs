using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

public void TryAgain(){
    SceneManager.LoadScene("SimpleClicker");
}

public void MainMenu(){
    SceneManager.LoadScene("Main");
}
}
