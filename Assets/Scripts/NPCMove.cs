using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    //----------------------------------------------------------------------------------------------------------------
    // Serialized fields
    //----------------------------------------------------------------------------------------------------------------
    //[SerializeField] private Transform _target;
    //[SerializeField] private Camera _cam;
    
    //----------------------------------------------------------------------------------------------------------------
    // Non-serialized fields
    //----------------------------------------------------------------------------------------------------------------
    private NavMeshAgent _navMeshAgent;

    //----------------------------------------------------------------------------------------------------------------
    // Unity events
    //----------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        //_cam = GetComponent<Camera>();
        //_navMeshAgent.updateRotation = false;
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);
        Physics.Raycast(ray, out hitInfo);
        
        if (Input.GetMouseButtonDown(0))
        {
            _navMeshAgent.SetDestination(hitInfo.point);
        }
    }
}
