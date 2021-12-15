using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadTime = 1f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("LevelReset", ReloadTime);

        }
    }
    void LevelReset()
    {
        SceneManager.LoadScene(0);
    }
}
