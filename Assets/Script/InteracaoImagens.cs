using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoImagens : MonoBehaviour
{
    public GameObject promptUI;
    public GameObject[] imagens;

    private int index = 0;
    private bool playerInRange = false;
    private bool mostrando = false;

    void Start()
    {
        promptUI.SetActive(false);

        foreach (GameObject img in imagens)
        {
            img.SetActive(false);
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !mostrando)
        {
            mostrando = true;
            index = 0;
            imagens[index].SetActive(true);
        }

        if (mostrando && Input.GetKeyDown(KeyCode.Space))
        {
            imagens[index].SetActive(false);
            index++;

            if (index < imagens.Length)
            {
                imagens[index].SetActive(true);
            }
            else
            {
                mostrando = false;
            }
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
            playerInRange = false;
        }
    }
}
