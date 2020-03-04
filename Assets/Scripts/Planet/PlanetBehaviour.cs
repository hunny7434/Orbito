﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehaviour
{
    Planet planet;
    Transform planetTransform;

    PlanetBehaviour(Planet planet)
    {
        this.planet = planet;
        planetTransform = planet.transform;
    }

    public void MoveFront()
    {
        planetTransform.Translate(0, planet.MoveSpeed * Time.deltaTime, 0);
    }

    public void Destroy()
    {
        planet.gameObject.SetActive(false);
        Debug.Log("Destroy");
    }

    public void Rotate(Vector3 center)
    {
        float deg = (planet.MoveSpeed / Vector3.Distance(center, planetTransform.position)) * Mathf.Rad2Deg * Time.deltaTime;

        var antiClockwiseDir = Vector2.Perpendicular(planetTransform.position - center).normalized;
        if (Vector2.Dot(antiClockwiseDir, planetTransform.up) > 0) deg = -deg;

        planetTransform.RotateAround(center, -Vector3.forward, deg);
    }
}
