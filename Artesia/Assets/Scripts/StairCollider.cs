using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StairCollider : MonoBehaviour
{
    [SerializeField] GameObject Player;
    bool bTriggerEnter = false;
    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player" && !bTriggerEnter){
            if(gameObject.GetComponent<Collider2D>().bounds.center == other.bounds.center){
                Time.timeScale = 0f;
                UIManager.instance.SetActiveNextStageUI(true);
                bTriggerEnter = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player" && bTriggerEnter){
            bTriggerEnter = false;
        }
    }

}