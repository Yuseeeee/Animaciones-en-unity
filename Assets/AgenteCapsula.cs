using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AgenteCapsula : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    public Transform targetTR;
    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        agent.destination = targetTR.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
