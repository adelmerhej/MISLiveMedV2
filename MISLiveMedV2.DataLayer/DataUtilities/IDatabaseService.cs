using System;

namespace MISLiveMed.DataLayers.DataUtilities
{
	public interface IDatabaseService
	{
		string GetServerDateTime();
		DateTime GetServerDateTimeRaw();
	}
}
