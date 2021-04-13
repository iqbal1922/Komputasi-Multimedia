using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehicleBehaviour;

public class CarController : MonoBehaviour
{

    public GameObject car;
    public GameObject up;
    public GameObject down;

    private WheelVehicle carComponent;

    void Start()
    {
      carComponent = car.GetComponent<WheelVehicle>();

    }

    void Update()
    {

      if(up.GetComponent<ButtonStateManager>().downed) {
        if(carComponent.manualityThrottle < 1f)
          carComponent.manualityThrottle += 0.1f;

      }else if(down.GetComponent<ButtonStateManager>().downed) {
        if(carComponent.manualityThrottle > -1f)
          carComponent.manualityThrottle -= 0.1f;
      }else{
        if(carComponent.manualityThrottle != 0f) {

          if(carComponent.manualityThrottle < 0f)
            carComponent.manualityThrottle += 0.05f;

          if(carComponent.manualityThrottle > 0)
            carComponent.manualityThrottle -= 0.05f;

        }
      }

      carComponent.manualityTurn = Input.acceleration.x;

    }
}
