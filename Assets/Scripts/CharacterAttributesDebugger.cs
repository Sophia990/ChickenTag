using UnityEngine;

public class CharacterAttributesDebugger : MonoBehaviour
{
    public CharacterAttributes characterAttributes;

    // Start is called before the first frame update
    void Start()
    {
        characterAttributes = GetComponent<CharacterAttributes>();
    }

    private void OnDrawGizmos()
    {
        if (characterAttributes == null)
        {
            return;
        }
   
        if (characterAttributes.It == true)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position + transform.right, 0.5f);
        }
        if (characterAttributes.frozen == true)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(transform.position + (transform.right * -1), 0.5f);
        }
        
    }
}
