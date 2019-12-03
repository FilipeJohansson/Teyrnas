using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleDoorBehaviour : MonoBehaviour {
    
    public void openCastleDoor() {
        Vector2 target = new Vector2(transform.position.x, 1f);

        transform.position = Vector2.Lerp(transform.position, target, 1 * Time.deltaTime);

    }

}
