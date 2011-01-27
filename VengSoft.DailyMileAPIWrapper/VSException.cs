using System;
using System.Collections.Generic;
using System.Text;

namespace VengSoft.DailyMileAPIWrapper
{
	public class VSException : Exception
	{
		private int errorCode;

		/// <summary>
		/// Error code
		/// </summary>
		public int ErrorCode
		{
			get { return this.errorCode; }
		}


		private void BuildTAException(int errorCode)
		{

			this.errorCode = errorCode;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Caller Supplied error Text</param>
		public VSException(string message)
			: base(message)
		{
			this.errorCode = 0;

		}

		public VSException(int errorCode)
			: base()
		{
			this.BuildTAException(errorCode);
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Caller Supplied error Text</param>
		/// <param name="innerException">Exception cuaght and passed on</param>
		public VSException(string message, Exception innerException)
			: base(message, innerException)
		{
			errorCode = 0;
		}

		/// <summary>
		/// To String
		/// </summary>
		/// <returns>Returns string representation of Excpetion</returns>
		public override string ToString()
		{
			if (this.InnerException != null)
				return "YesPlatformCSharp:TAException: [ErrorCode: " + this.errorCode.ToString() + " " + this.Message + "]\n" + this.InnerException.ToString() + "\n";
			else
				return "YesPlatformCSharp:TAException: [ErrorCode: " + this.errorCode.ToString() + " " + this.Message + "]\n";
		}

	}
}
