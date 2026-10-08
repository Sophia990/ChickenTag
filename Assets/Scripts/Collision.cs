using UnityEngine;

public class Collision : MonoBehaviour
{
    public CharacterAttributes attributes;

    // Start is called before the first frame update
    void Start()
    {
        attributes = gameObject.GetComponent<CharacterAttributes>();
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (attributes.frozen == false)
        {
            CharacterAttributes collidedCharacter = collision.gameObject.GetComponent<CharacterAttributes>();

            if (collidedCharacter != null)
            {
                SwitchRoles(collidedCharacter);
            }
        }

    }

    void SwitchRoles(CharacterAttributes otherCharacter)
    {

        if (attributes.It == true)
        {
            otherCharacter.MakeStateIt();
            attributes.MakeStateNotIt();
        }

    }

}
