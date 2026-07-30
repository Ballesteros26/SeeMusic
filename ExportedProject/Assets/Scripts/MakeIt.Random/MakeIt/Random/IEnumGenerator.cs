namespace MakeIt.Random
{
	public interface IEnumGenerator<TEnum> where TEnum : struct
	{
		TEnum Next();

		string NextName();

		TEnum Next(out string name);
	}
}
