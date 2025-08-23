using UnityEngine;
using UnityEngine.AI;

public class KidsMotion : MonoBehaviour
{
    [SerializeField] NavMeshAgent myNavMeshAgent;

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }
    }

    void SetDestinationToMousePosition ()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            myNavMeshAgent.SetDestination(hit.point);
        }
    }
}
