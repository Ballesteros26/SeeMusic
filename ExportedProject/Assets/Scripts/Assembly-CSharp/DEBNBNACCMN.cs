using System;

[Flags]
public enum DEBNBNACCMN
{
	Alpha = 1,
	RGB_R = 2,
	RGB_G = 4,
	RGB_B = 8,
	HSV_H = 0x10,
	HSV_S = 0x20,
	HSV_V = 0x40,
	HSL_H = 0x80,
	HSL_S = 0x100,
	HSL_L = 0x200
}
