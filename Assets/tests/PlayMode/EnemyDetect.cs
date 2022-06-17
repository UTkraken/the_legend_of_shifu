using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemyDetect
{
    // A Test who check if an Enemy detect a player
    [Test]
    public void EnemyDetect()
    {
        Assert.AreEqual(checkForPlayer, true);
    }

    // A Test who check if an Enemy Walk
    [Test]
    public void EnemyWalking()
    {
        Assert.AreEqual(walkToPlayer, true);
    }

    // A Test who check Enemy Speed
    [Test]
    public void EnemySpeed()
    {
        Assert.AreEqual(ennemyDetect.speed, 0.4f);
    }

    // A Test who check the range for an enemy
    [Test]
    public void EnemyDetectRange()
    {
        Assert.AreEqual(ennemyDetect.detectRange, 5.0f);
    }
}
