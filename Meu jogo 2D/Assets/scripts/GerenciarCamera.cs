using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciarCamera : MonoBehaviour {

    public Camera camera;

    private static float minX;
    private static float maxX;
    private static float minY;
    private static float maxY;

    private float distanciaZ;

    // Use this for initialization
    void Start () {
        distanciaZ = transform.position.z - camera.transform.position.z;

        minX = camera.ScreenToWorldPoint(new Vector3(0, 0, distanciaZ)).x;
        maxX = camera.ScreenToWorldPoint(new Vector3(Screen.width, 0, distanciaZ)).x;

        minY = camera.ScreenToWorldPoint(new Vector3(0, 0, distanciaZ)).y;
        maxY = camera.ScreenToWorldPoint(new Vector3(0, Screen.height, distanciaZ)).y;

    }

    public static float MinY()
    {
        return minY;
    }

    public static float MaxY()
    {
        return maxY;
    }

    public static float MinX()
    {
        return minX;
    }

    public static float MaxX()
    {
        return maxX;
    }


}
