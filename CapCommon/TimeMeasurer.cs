using System;

public class TimeMeasurer
{
	public int Count;

	public double TotalMSecond;

	public DateTime Begin;

	public void Start()
	{
		Begin = DateTime.Now;
	}

	public double Elapsed()
	{
		double totalMilliseconds = (DateTime.Now - Begin).TotalMilliseconds;
		TotalMSecond += totalMilliseconds;
		Count++;
		return totalMilliseconds;
	}

	public float Avg()
	{
		float num = (float)TotalMSecond;
		if (Count != 0)
		{
			return num / (float)Count;
		}
		return 0f;
	}
}
