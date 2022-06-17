using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMouvement
{
    // A Test who check the speed of the player
    [Test]
    public void PlayerMoveSpeed()
    {
        Assert.AreEqual(moveSpeed, 0.7f);
    }
    
}
