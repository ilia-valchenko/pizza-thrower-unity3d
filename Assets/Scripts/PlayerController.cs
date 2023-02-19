using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 17.0f;
    private const float XLimit = 20.0f;

    private float horizontalInput;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -XLimit)
        {
            transform.position = new Vector3(-XLimit, transform.position.y, transform.position.z);
        }

        if (transform.position.x > XLimit)
        {
            transform.position = new Vector3(XLimit, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // static method
            Object.Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
        }

        this.horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * this.horizontalInput * Time.deltaTime * Speed);
    }
}
