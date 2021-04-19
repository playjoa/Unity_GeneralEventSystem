using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEventArea : MonoBehaviour
{
    [SerializeField]
    private GameEvent enterEvent, exitEvent;

    [SerializeField]
    private string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
            ActivateEnterEvent();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
            ActivateExitEvent();    
    }

    void ActivateEnterEvent() 
    {
        enterEvent?.Invoke();
        Debug.Log("Player entrou na area!");
    }

    void ActivateExitEvent()
    {
        exitEvent?.Invoke();
        Debug.Log("Player SAIU da area!");
    }
}
