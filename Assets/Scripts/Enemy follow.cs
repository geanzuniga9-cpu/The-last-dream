using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public GameObject Target;
    public float Speed;
    public float radiusAttack;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();

    }

    public void FollowTarget()
    {
        Vector3 dir = (Target.transform.position - transform.position).normalized;

        if (Vector3.Distance(Target.transform.position, transform.position) < radiusAttack)
        {
            Debug.Log("atacando >:l ");
        }
        else
        {
            transform.position += dir * Speed * Time.deltaTime;
        }

    }

}
