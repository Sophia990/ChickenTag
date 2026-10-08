using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float rotationSpeed;
    public float xRange;
    public float zRange;

    private float speed;
    private CharacterAttributes attributes;

    // Start is called before the first frame update
    void Start()
    {
        attributes = gameObject.GetComponent<CharacterAttributes>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attributes.it == true)
        {
            speed = attributes.itSpeed;
        }
        else
        {
            speed = attributes.notItSpeed;
        }

        if (attributes.frozen == false)
        {
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
            }

            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }

            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
        }

    }
}
