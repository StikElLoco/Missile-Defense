using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform[] tower = new Transform[3];
    public Transform[] turret = new Transform[3];

    public Transform target;

    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        MoveTarget();
        RotateTowers();
        RotateTurrets();
    }

    private void GetInputs()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 50;
    }

    private void RotateTowers()
    {
        for (int i = 0; i < tower.Length; i++)
        {
            Vector3 targetPos = new Vector3(target.position.x, tower[i].position.y, target.position.z);
            tower[i].LookAt(targetPos);
        }
    }

    private void RotateTurrets()
    {
        for (int i = 0; i < turret.Length; i++)
        {
            turret[i].LookAt(target);
        }
    }

    private void MoveTarget()
    {
        target.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
