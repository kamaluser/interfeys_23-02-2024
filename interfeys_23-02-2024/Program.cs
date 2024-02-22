
#region MIN
static int MinOfList(List<int> list)
{
	if (list.Count>0)
	{
		int min = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i] < min) min = list[i];
		}
		return min;
	}
	else
	{
		throw new ArgumentException("List is empty!");
	}
}

List<int> list = new List<int>();
try
{
    Console.WriteLine(MinOfList(list));
}
catch (Exception)
{
    Console.WriteLine("List is Empty!");
}
#endregion

#region MAX
static int MaxOfList(List<int> list)
{
    if (list.Count > 0)
    {
        int max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > max) max = list[i];
        }
        return max;
    }
    else
    {
        throw new ArgumentException("List is empty!");
    }
}


List<int> list2 = new List<int>() {1, 5, 7, -9, 23, 78, -34};
try
{
    Console.WriteLine(MaxOfList(list2));
}
catch (Exception)
{
    Console.WriteLine("List is Empty!");
}
#endregion

#region SORT
static void Sort(List<int> list)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        for (int j = i + 1; j < list.Count; j++)
        {
            if (list[i] > list[j])
            {
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}

Sort(list2);
foreach (var item in list2)
{
    Console.WriteLine(item);
}

#endregion
