using UnityEngine;

public class movement : MonoBehaviour
{
    public Camera mainCam;
    public float speed;
    float inputY;
    float inputX;
    public Rigidbody2D body;
    public Transform graphic;
    public float bounceForce;
    public float iceFriction;
    Animator anim;
    public bool mobile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (inputX != 0 || inputY != 0)
        {
            graphic.up = new Vector3(inputX, inputY);
            anim.SetBool("walk", true);
            


        }

        else
        {
            anim.SetBool("walk", false);
        }
        if (!mobile);
        {
            inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
       
        }
        if (Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0)
        {
            mobile = false;
        }
       

        if (Input.GetMouseButton(0))
        {
            mobile = true;
        }
        if (mobile)
        {
            Vector3 direction = mainCam.ScreenToWorldPoint(Input.mousePosition) -transform.position;
            direction /= Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
            
            
            if (Input.GetMouseButton(0))
            {
                inputX = direction.x;
                inputY = direction.y;
            }
            else
            {
                inputX = 0; 
                inputY = 0;
            }

        }
        body.linearVelocity += new Vector2(inputX, inputY) * Time.deltaTime * speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ice")
        {
            float difference = body.linearDamping / iceFriction;
            body.linearDamping = iceFriction;
            speed /= difference;


        }
        if (collision.tag == "bounce")
        {
            Vector3 direction = transform.position - collision.gameObject.transform.position;
            direction.Normalize();
            body.linearVelocity = Vector2.zero;
            body.AddForce(direction * bounceForce);


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ice")
        {
            body.linearDamping = 20;
            speed = 100;


        }
    }
}
