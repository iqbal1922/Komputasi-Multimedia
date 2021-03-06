using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlock : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animatorController;
    
    void Start() {
        animatorController = GetComponent<Animator>();
    }
    
    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.CompareTag("Player")){
            animatorController.SetTrigger("Fall");
        }
    }
}