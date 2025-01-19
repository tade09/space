using UnityEngine;
using UnityEngine.SceneManagement;
public class lose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetToLoseScreen()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        PlayerPrefs.SetString("scene",currentScene.name);
        Debug.Log(PlayerPrefs.GetString("scene"));
        PlayerPrefs.Save();
        SceneManager.LoadScene("lose");
        

    }
}
