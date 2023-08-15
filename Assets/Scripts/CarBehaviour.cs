using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    Quaternion targetRotation;

    [SerializeField] public float turnSpeed = 120;
    [SerializeField] public float accel = 2000;

    Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        SetRotationPoint();

    }

    private void SetRotationPoint()
    {
        //tworzenie promienia od origin kamery do kursora myszki
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //tworzenie p³aszczyzny
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        
        float distance;

        
        if(plane.Raycast(ray, out distance))
        {
            //punkt przeciecia promiena z p³aszczyzn¹
            Vector3 target = ray.GetPoint(distance);
            //wektor, w kierunku którego chcemy obrocic pojazd
            Vector3 direction = target - transform.position;
            //argument wektora direction na plaszczyŸnie Oxz od razu
            //zamieniony z radianow na stopnie
            float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //utworzenie z rotationAngle kata obrotu wzgledem osi y
            targetRotation = Quaternion.Euler(0, rotationAngle, 0);
        }
    }

    private void FixedUpdate()
    {
        //zmienna pobierajaca predkosc pojazdu podzielona przez 1000 aby wykorzystana
        //przy kalkulacji predkosci obrotu za szybko nie przekrecala samochodu
        float speed = _rigidBody.velocity.magnitude / 1000;
        //if LPM->1, else if PPM->-1, else 0 * przyspieszenie * update silnika gry
        float accelInput = accel * (Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1) ? -1 : 0)*Time.fixedDeltaTime;
        //przesuniecie pojazdu do przodu
        _rigidBody.AddRelativeForce(Vector3.forward * accelInput);
        //Lerp (interpolacja) czyli obrocenie pojazdu od jego wlasnego kata do kata
        //targetRotation o predkosci turnSpeed * update silnika * Clamp od -1 do 1 na
        //zmiennej speed zeby samochod obracal sie tylko gdy jedzie
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Mathf.Clamp(speed, -1, 1) * Time.fixedDeltaTime);
    }
}
