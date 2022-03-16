using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA
{

    private string type;

    public IA(string type)
    {
        this.type = type;
    }

    public Cards drawCard()
    {
        switch(this.type)
        {
            case "basic":
                //todo
                break;
        }

        return null;
    }
}
