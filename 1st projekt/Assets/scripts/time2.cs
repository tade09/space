using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class time2 : MonoBehaviour
{
    lose loseSript;
    public Image fill;
    public float timer;
    public float startTime;
    public float percentOfStartTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = startTime / 100 * percentOfStartTime;
        loseSript = FindObjectOfType<lose>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (fill != null )
        fill.fillAmount = timer / startTime;

        if (timer > startTime)
            timer = startTime;
        if (timer <= 0)
            loseSript.GetToLoseScreen();
    }

}
