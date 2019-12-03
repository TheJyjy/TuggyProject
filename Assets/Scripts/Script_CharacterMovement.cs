using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Script_CharacterMovement : MonoBehaviour
{

    public GameObject _prefabTarget;
    public LayerMask _clickableLayer;
    public AIDestinationSetter _aidestinationSetter;
    public Script_Grass _targetGrass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Onclick();
        }


        if (Input.GetButtonDown("Eat") && _targetGrass != null)
        {
            _targetGrass.Eat();
        }

    }

    void Onclick()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast (ray, out hit, Mathf.Infinity, _clickableLayer))
        {            
            Debug.Log(hit.collider.gameObject);

            _aidestinationSetter.TargetPosition(hit.point);
        }
        // Créer un rayon a partir de la position de la souris et retourne ses coordonnées
    }

    public void OnGrassEnter(Script_Grass grass)
    {
        if (_targetGrass == null)
        {
            _targetGrass = grass;
        }
    }



    public void OnGrassExit(Script_Grass grass)
    {

        if (grass == _targetGrass)
        {
            _targetGrass = null;
        }
    }

}
