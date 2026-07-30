using System;
using UnityEngine;

public class RestrictInterfaceAttribute : PropertyAttribute
{
	public Type RestrictType { get; set; }

	public RestrictInterfaceAttribute(Type restrictType)
	{
	}
}
