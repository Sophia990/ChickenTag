using UnityEngine;
using UnityEngine.UI;

public class ItIndicator : MonoBehaviour
{
    private CharacterAttributes itNPC;

    // Update is called once per frame
    void Update()
    {
        CharacterAttributes[] npcList = GameObject.FindObjectsOfType<CharacterAttributes>();
        foreach (CharacterAttributes npc in npcList)
        {
            if (npc.It == true)
            {
                itNPC = npc;
            }
        }
        transform.position = itNPC.transform.position;
    }
}
