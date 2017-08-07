using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
  public Vector3 Rotation;

  public bool Orbit;

  public Vector3 OrbitAxis;

  public GameObject ObjectToOrbit;

  public float OrbitSpeed;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Orbit)
      transform.RotateAround(ObjectToOrbit.transform.position, OrbitAxis, OrbitSpeed * Time.deltaTime);
    else
      transform.Rotate(Rotation * Time.deltaTime);
  }
}
