using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public interface IInputReader<T>
{
    IValue<T>[][] ReadInputToGrid();
}
