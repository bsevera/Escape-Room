using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{

    public void BatteryInserted()
    {                
        Destroy(this.gameObject);
    }
}
