using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other?.gameObject != null)
        {
            // Destroy other gameObject that collides the current object.
            Destroy(other.gameObject);
        }
        
        if (this.gameObject != null)
        {
            // Destroy the current gameObject.
            Destroy(this.gameObject);
        }
    }
}
