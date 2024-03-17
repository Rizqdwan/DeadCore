using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] private Animator elevator = null;

    [SerializeField] private bool UpTrigger = false;

    [SerializeField] private bool DownTrigger = true;

    [SerializeField] private string elevatorUp = "ElevatorUp";

    [SerializeField] private string elevatorDown = "ElevatorDown";

    [SerializeField] public Transform ElevatorCollider;

    void Start()
    {
        //Transform pintu = Instantiate(pintuCollider) as Transform;
        //Physics.IgnoreCollision(pintu.GetComponent<Collider>(), GetComponent<Collider>());
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (DownTrigger)
            {
                elevator.Play(elevatorDown, 0, 0.0f);
                gameObject.SetActive(false);
                Debug.Log("Elevator going down");
            }

            else if (UpTrigger)
            {
                elevator.Play(elevatorUp, 0, 0.0f);
                gameObject.SetActive(true);
                Debug.Log("Elevator going up");

                Destroy(ElevatorCollider.gameObject);
            }
        }
    }
}
