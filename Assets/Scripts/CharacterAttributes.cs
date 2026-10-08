using System.Collections;
using UnityEngine;

public class CharacterAttributes : MonoBehaviour
{
    public bool it;
    public bool frozen;
    public float itSpeed = 5;
    public float notItSpeed = 10;
    public bool It { get => it; set => it = value; }

    IEnumerator Delay()
    {
        frozen = true;
        yield return new WaitForSeconds(2);
        frozen = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        frozen = false;
    }

    internal void MakeStateIt()
    {
        It = true;
        frozen = true;
        StartCoroutine(Delay());
    }

    internal void MakeStateNotIt()
    {
        It = false;
        frozen = false;
    }
}
