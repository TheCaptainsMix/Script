using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
       if (Other.gameObject.tag == "Player") { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } 
    }
}
