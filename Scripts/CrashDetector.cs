using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float ReloadTime = 1f;
    [SerializeField] ParticleSystem deathEffect;
    [SerializeField] AudioClip ffviiDeathSFX;
    float isDead;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            deathEffect.Play();
            if(isDead == 0){
                GetComponent<AudioSource>().PlayOneShot(ffviiDeathSFX);
            }
            isDead += 1;
            Invoke("LevelReset", ReloadTime);
        }
    }

    void LevelReset() {
        Debug.Log("Bonk!");
        SceneManager.LoadScene(0);
    }
}
