using UnityEngine;
using UnityEngine.SceneManagement;

public class killplayer : MonoBehaviour
{
    lose loseSript;
    private void Start()
    {
        loseSript = FindObjectOfType<lose>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            loseSript.GetToLoseScreen();
        }
    }




}
