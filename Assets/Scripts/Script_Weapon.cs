using UnityEngine;

public class Script_Weapon : MonoBehaviour
{
    public GameObject _bullet;
    public float _speed = 100f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }


    }


    void Shoot ()
    {
        GameObject _instBullet = Instantiate(_bullet,transform.position,Quaternion.identity) as GameObject;
        Rigidbody _instBulletRigidbody = _instBullet.GetComponent<Rigidbody>();
        _instBulletRigidbody.AddForce(Vector3.forward * _speed);
    }
}

