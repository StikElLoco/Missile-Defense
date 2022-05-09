using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;

    [SerializeField] PlayerController playerController;

    [SerializeField] EnemyManager enemyManager;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = enemyManager.AcquireTarget();
        }
        if(target != null)
        {
            MoveToTarget(target);
        }
    }



    public void MoveToTarget(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, projectileSpeed * Time.deltaTime);

        Vector3 direction = (target - transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, projectileSpeed);
    }

    public void Explode()
    {

    }
}
