using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ObjectSet : MonoBehaviour
{
    public int id;
    public Rigidbody rigidbody;
    public ObjectOn objectOn;
    public Interactable interactable;
    public Throwable throwable;
    public MeshCollider collider;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        interactable = GetComponent<Interactable>();
        throwable = GetComponent<Throwable>();
        collider = GetComponent<MeshCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Id idScript = other.GetComponent<Id>();
        if(id == idScript.id)
        {
            interactable.enabled = false;
            rigidbody.isKinematic = true;
            Destroy(throwable);
            Destroy(interactable);
            rigidbody.freezeRotation = true;
            rigidbody.isKinematic = true;
            rigidbody.useGravity = false;
            collider.enabled = false;
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            //other.transform.SetParent(transform);
            transform.SetParent(other.transform);
            idScript.enabled = false;
            objectOn.isOn[id - 1] = true;
            objectOn.Score++;
            //gameObject.SetActive(false);
        }
    }
}
