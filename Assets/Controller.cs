using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public NavMeshAgent playerAgent;
    [SerializeField]
    GameObject lastPos;
    bool isMoving;
    [SerializeField]
    GameObject hammer;
    private void Start()
    {
        ObstacleMovement();
    }
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
    void ObstacleMovement()
    {
        iTween.RotateTo(hammer, iTween.Hash("z", -90, "time", 1, "loopType", iTween.LoopType.pingPong, "easetype", iTween.EaseType.easeInCirc)) ;
    }
  
}