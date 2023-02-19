using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float ZTopBound = 300.0f;
    private const float ZLowerBound = -300.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > ZTopBound && this.gameObject != null)
        {
            Destroy(this.gameObject);
        } else if (transform.position.z < ZLowerBound && this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
