using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoTeste : MonoBehaviour
{
    public GameObject promptUI;
    public GameObject dialogUI;

    private bool playerInRange = false;

    void Start()
    {
        promptUI.SetActive(false);
        dialogUI.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogUI.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(true);
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(false);
            dialogUI.SetActive(false);
            playerInRange = false;
        }
    }
}
