using System.Collections;
using UnityEngine;

public class AudioObject : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update(){
        if (!audioSource.isPlaying)
            Destroy(gameObject); 
    }
}
