using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollision : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("You Died");
    }
}
