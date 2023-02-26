var nums = new int[] { 6, 8, 6, 8, 2 };
var dict = new Dictionary<int, int>();

for (int i=0; i<nums.Length; i++)
{
    int n = nums[i];
    if (dict.ContainsKey(n))
        dict[n] = dict[n] + 1;
    else
        dict[n] = 1;
}

var result = 0;
var max = dict.Values.Max();
foreach (int key in dict.Keys)
    if (dict[key] >= max)
        result = key;

Console.WriteLine(result);
