using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float rotationSpeed;
    public float randomOffsetMagnitude;

    private UnityEngine.AI.NavMeshAgent agent;
    private CharacterAttributes attributes;
    private CharacterAttributes itNPC;
    private Transform[] targets;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        attributes = gameObject.GetComponent<CharacterAttributes>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attributes.It == true && attributes.frozen == false)
        {

            agent.speed = attributes.itSpeed;

            CharacterAttributes[] characterAttributes = FindObjectsOfType<CharacterAttributes>();

            targets = new Transform[characterAttributes.Length];

            int index = 0;
            for (int i = 0; i < characterAttributes.Length; i++)
            {
                if (characterAttributes[i].transform != transform)
                {
                    targets[index] = characterAttributes[i].transform;
                    index++;
                }
            }
            Transform closestTarget = FindClosestTarget();

            if (closestTarget != null)
            {
                MoveTowardsTarget(closestTarget);
            }
        }

        else if (attributes.It == false && attributes.frozen == false)
        {
            agent.speed = attributes.notItSpeed;

            CharacterAttributes[] npcList = GameObject.FindObjectsOfType<CharacterAttributes>();
            foreach (CharacterAttributes npc in npcList)
            {
                if (npc.It == true)
                {
                    itNPC = npc;
                }
            }

            Vector3 awayDirection = (transform.position - itNPC.transform.position).normalized;
            Vector3 randomOffset = Random.onUnitSphere * randomOffsetMagnitude; // Adjust the magnitude as needed

            // Use NavMeshAgent for smooth movement
            agent.SetDestination(transform.position + awayDirection + randomOffset);
        }

        else if (attributes.frozen == true)
        {
            agent.SetDestination(transform.position);
        }

    }

    Transform FindClosestTarget()
    {

        Transform closestTarget = null;
        float closestDistance = float.MaxValue;
        foreach (Transform target in targets)
        {
            if (target != null)
            {
                float distance = Vector3.Distance(transform.position, target.position);

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestTarget = target;
                }
            }

        }

        return closestTarget;
    }

    void MoveTowardsTarget(Transform target)
    {

        agent.SetDestination(target.position);
    }
}
