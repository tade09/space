using UnityEngine;
using UnityEngine.SceneManagement;

public class clock : MonoBehaviour
{
    public time2 timeManager;
    public float addTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeManager=FindObjectOfType<time2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            timeManager.timer += addTime;
            Destroy(gameObject);
        }
    }
}
