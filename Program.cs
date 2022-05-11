
//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 3;

//RotateArray r = new RotateArray(); r.Rotate(array, k);

using BinarySearch;


DuplicateArray da = new DuplicateArray();
int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
var ans = da.ContainsDuplicate(nums);
Console.WriteLine(ans);

