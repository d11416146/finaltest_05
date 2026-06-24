using System;

public class print
{
	public static  string str= "";
	public void printNum()
	{
		lock (this)
		{
			for(int i = 1; i <= 5; i++)
			{
				str += Thread.CurrentThread.Name + "[" + i + "]" + "\n";
				Thread.Sleep(new Random().Next(5, 20));
			}
			str += "\n";
		}
	}
}
