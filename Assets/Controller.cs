using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public NavMeshAgent playerAgent;
    [SerializeField]
    GameObject lastPos;
    bool isMoving;
    void Update()
    {
        Debug.Log(isMoving);
        if (Input.GetMouseButtonDown(0))
        {

            isMoving = true;
            

        }
         if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }
       
        if (isMoving)
        {
            playerAgent.isStopped = false;
             playerAgent.SetDestination(lastPos.transform.position);
        }
        else
        {
            playerAgent.isStopped = true; 
        }
    }
  
}