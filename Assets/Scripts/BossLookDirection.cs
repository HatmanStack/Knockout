using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLookDirection : MonoBehaviour
{

    //public float speed;
    private CapsuleCollider enemyCap;
    private Animator enemyAni;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        enemyCap = GetComponent<CapsuleCollider>();
        enemyAni = GetComponent<Animator>();
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyAni.GetCurrentAnimatorStateInfo(0).IsName("knockout_V1") ||
            enemyAni.GetCurrentAnimatorStateInfo(0).IsName("Knockouts_Countdown_V1"))
        {
            //enemyCap.direction = 0;
            enemyCap.center = new Vector3(0, 2, 0);
        }else
        {
            //enemyCap.direction = 1;
            enemyCap.center = new Vector3(0, 1, 0);
        }

            if (target != null)
        {
            transform.LookAt(target);
        }
        
        /**Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }**/
    }
}
