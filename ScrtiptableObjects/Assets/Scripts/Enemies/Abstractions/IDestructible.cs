using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestructible
{
    public float Health { get; }
    public void TakeDamage(float damage);
}