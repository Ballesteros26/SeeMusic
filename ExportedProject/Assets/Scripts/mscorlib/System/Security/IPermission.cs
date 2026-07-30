namespace System.Security
{
	/// <summary>Defines methods implemented by permission types.</summary>
	public interface IPermission : ISecurityEncodable
	{
		/// <summary>Throws a <see cref="T:System.Security.SecurityException" /> at run time if the security requirement is not met.</summary>
		void Demand();

		/// <summary>Determines whether the current permission is a subset of the specified permission.</summary>
		/// <returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns>
		/// <param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
		bool IsSubsetOf(IPermission target);
	}
}
