using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//base for all projectile weapons to be put on prefabs

public class ProjectileWeaponBehaviour : MonoBehaviour
{

    protected Vector3 direction;
    public float destroyAfterSeconds;

    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;
        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;


        if(dirx < 0 && diry == 0)
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if(dirx == 0 && diry < 0) //down
        {
            scale.y = scale.y * -1;
        }
        else if(dirx == 0 && diry > 0) //up
        {
            scale.x = scale.x * -1;
        }
        else if(dir.x > 0 && dir.y > 0) //up right
        {
            rotation.z = 0f;
        }
        else if(dir.x > 0 && dir.y < 0) //down right
        {
            rotation.z = -90f;
        }
        else if(dir.x < 0 && dir.y > 0) //up left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = -90f;
        }
        else if(dir.x < 0 && dir.y < 0) //down left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = 0f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
