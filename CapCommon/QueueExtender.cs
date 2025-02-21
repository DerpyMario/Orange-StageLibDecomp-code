using System.Collections.Generic;

public static class QueueExtender
{
	public static double Sum(this Queue<double> queue)
	{
		double num = 0.0;
		foreach (double item in queue)
		{
			num += item;
		}
		return num;
	}
}
