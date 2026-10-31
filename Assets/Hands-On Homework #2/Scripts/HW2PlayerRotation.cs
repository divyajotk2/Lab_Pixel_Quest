using System.Runtime.CompilerServices;
using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera _camera;
    private string Cameraname = "Game_Camera";  
    private Vector3 _mousePosition; 

    private void Start()
    {
        _camera = GameObject.Find(Cameraname).GetComponent<Camera>();
    }
    private void Update()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = _mousePosition - transform.position;
        float rot2 = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot2-90);
    }

}
