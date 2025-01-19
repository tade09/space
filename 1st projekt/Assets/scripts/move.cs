using UnityEngine;

public class move: MonoBehaviour
{
    public GameObject[] wayPoint;

    public int index;

    bool forward = true;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index>=0&& index< wayPoint.Length)
        transform.position = Vector3.MoveTowards(transform.position, wayPoint[index].transform.position,speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, wayPoint[index].transform.position)<0.2f && forward == true)
        {
            index += 1;
            if (index == wayPoint.Length )
            {
                forward = false;
                index = wayPoint.Length - 1;
            }
        }
        if (Vector3.Distance(transform.position, wayPoint[index].transform.position) < 0.2f && forward == false)
        {
            index -= 1;
            if (index == -1)
            {
                forward = true;
                index =0;
            }
        }
    }
}
