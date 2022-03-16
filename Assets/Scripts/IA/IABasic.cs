using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IABasic : IA
{
    private Creature parent;

    public IABasic(Creature parent)
    {
        this.parent = parent;
    }

    public Cards drawCard()
    {
        //to do
        return null;
    }
}
