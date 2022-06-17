using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FightManager
{
    // A Test who check the number of round
    [Test]
    public void FightManagementRound()
    {
        Assert.AreEqual(round, 0);
    }
}
