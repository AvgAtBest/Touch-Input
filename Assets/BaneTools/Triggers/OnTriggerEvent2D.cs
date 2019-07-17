using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent2D : MonoBehaviour
{
  public bool destroyOnEnter = false, destroyOnExit = false;

  public string hitTag;
  public UnityEvent onEnter, onStay, onExit;

  public Collider2D otherCollider;

  [HideInInspector] public bool hasBeenTriggered;

  public virtual void Reset()
  {
    Collider2D col = GetComponent<Collider2D>();
    if (col)
    {
      col.isTrigger = true;
    }
    else
    {
      Debug.LogWarning(string.Format("The GameObject {0} does not have a collider. This will not work with trigger events.", name));
    }
  }

  public virtual void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == hitTag || hitTag == "")
    {
      otherCollider = other;
      onEnter.Invoke();

      if (destroyOnEnter)
        Destroy(gameObject);
    }
  }

  public virtual void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == hitTag || hitTag == "")
    {
      otherCollider = other;
      onStay.Invoke();
    }
  }

  public virtual void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == hitTag || hitTag == "")
    {
      otherCollider = other;
      onExit.Invoke();

      if (destroyOnExit)
        Destroy(gameObject);
    }
  }
}