using UnityEngine;
using UnityEngine.AI;

public class KidsAnimations : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] NavMeshAgent agent;

    void Update()
    {
        animator.SetFloat("speed", agent.velocity.magnitude);
    }
}
