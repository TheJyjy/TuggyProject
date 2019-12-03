using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Grass : MonoBehaviour, Script_IEatable
{
    public void Eat()
    {
        Destroy(gameObject);
    }

    public void Effect()
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            other.GetComponentInParent<Script_CharacterMovement>().OnGrassEnter(this);        
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInParent<Script_CharacterMovement>().OnGrassExit(this);
        }
    }
}
