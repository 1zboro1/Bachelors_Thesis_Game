using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] Transform observable;
    [SerializeField] float aheadSpeed;
    [SerializeField] float followDamp;
    [SerializeField] float camHeight;

    Rigidbody _observableRigidBody;

    void Start()
    {
        _observableRigidBody = observable.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //Je¿eli nie ma nic do obserwowania to nic nie rób
        if (observable == null)
            return;
        //nowa pozycja kamery podniesiona o wektor (0,1,0) * camHeight oraz zmiana jej pozycji przy pomocy predkosci obiektu * aheadSpeed
        Vector3 targetPosition = observable.position + Vector3.up * camHeight + _observableRigidBody.velocity * aheadSpeed;
        //zmiana pozycji kamery z poprzedniej na nowa targetPosition co kazda klatke razy followDamp
        transform.position = Vector3.Lerp(transform.position, targetPosition, followDamp * Time.deltaTime);
    }
}
