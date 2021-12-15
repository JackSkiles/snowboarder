using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float ReloadTime = 1f;
    [SerializeField] ParticleSystem deathEffect;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            deathEffect.Play();
            Invoke("LevelReset", ReloadTime);
        }
    }

    void LevelReset() {
        Debug.Log("Bonk!");
        SceneManager.LoadScene(0);
    }
}
