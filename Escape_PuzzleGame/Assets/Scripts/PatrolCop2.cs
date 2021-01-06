using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolCop2 : NakedFat
{
    public Transform[] path;

    public int currentPoint;

    public Transform currentGoal;

    public float roundingDistance;

    //private bool goDown;

    public Animator aniChange;

    private void Awake()
    {
        //aniChange = GetComponent<AnimatorOverrideController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void CheckDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {

            if (currentState == EnemyState.idle || currentState == EnemyState.walk)
            {
                changeAnim(target.transform.position - transform.position);
                transform.position = Vector3.MoveTowards(transform.position, target.position, MoveSpeed * Time.deltaTime);

                myRidgidbody.MovePosition(target.transform.position);

                anim.SetBool("wakeUp", true);
            }
            else
            {
                //changeAnim(Vector2.zero);
                //ChangeState(EnemyState.idle);
                //anim.SetBool("wakeUp", false);

                //ChangeState(EnemyState.walk);

            }
        }
        else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            if (Vector3.Distance(transform.position, path[currentPoint].position) > roundingDistance)
            {
                changeAnim(target.transform.position - transform.position);
                transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, MoveSpeed * Time.deltaTime);
                myRidgidbody.MovePosition(target.transform.position);

            }
            else
            {
                //Debug.Log(1);
                ChangeGoal();
            }


        }
    }

    private void ChangeGoal()
    {
        if (currentPoint == path.Length - 1)
        {
            currentPoint = 0;

            currentGoal = path[0];

            //print(1);

            aniChange.SetBool("leftToRight", false);
        }
        else
        {
            currentPoint++;

            currentGoal = path[currentPoint];

            //print(2);

            aniChange.SetBool("leftToRight", true);
        }
    }
}
