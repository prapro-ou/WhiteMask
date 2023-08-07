using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(CircleCollider2D))]

public class bullet_grimReaper : bulletEnemyParent
{

    /*仮作成*/
    public override void initialize()
    {
        radius = 0.3f;
        speed = 0.1f;
    }

    public override void move()
    {
        transform.Translate (-speed, 0, 0);

    }

}