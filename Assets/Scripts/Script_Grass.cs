using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Grass : MonoBehaviour, Script_IEatable, Script_ITriggable
{
    public void Eat()
    {
        throw new System.NotImplementedException();
    }

    public void Effect()
    {
        throw new System.NotImplementedException();
    }

    public void Triggered(Collider objectInTrigger)
    {

        objectInTrigger.GetComponentInParent<Script_CharacterMovement>()._targetGrass = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Triggered(other);
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}
