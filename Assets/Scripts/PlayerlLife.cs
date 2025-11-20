using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class PlayerlLife : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Die();
        }


    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        Reloadlevel();
        Invoke(nameof(Reloadlevel), 1.3f);
    }



    void Reloadlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }











}