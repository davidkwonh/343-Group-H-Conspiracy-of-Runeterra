using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.position = Input.mousePosition;
    }
}