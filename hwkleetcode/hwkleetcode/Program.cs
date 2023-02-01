//Two Sum
public class Solution
{
    //method called twosum with two parameter
    public int[] TwoSum(int[] nums, int target) 
    {
        //create new dictionary object
        Dictionary<int, int> id = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (id.ContainsKey(complement))
            {
                return new int[] { id[complement], i };
            }
            else
            {
                id[nums[i]] = i;
            }
        }
        return null;
    }
}

//3 Sum
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        //Sort Array
        Array.Sort(nums);
        //Create variable to store final result
        var data = new List<IList<int>>();
        //temporary list to store pairs
        List<int> temp;

        for (int i = 0; i < nums.Length; i++)
        {   // remove duplicate from i
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                // remove duplicate from j
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    j++;
                    continue;
                }
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {
                    temp = new List<int>
                    {
                        nums[i], nums[j],nums[k]
                    };

                    data.Add(temp);
                    j++;
                    k--;
                }
                else if (sum < 0)
                {
                    j++;
                }
                else
                {
                    k--;
                }

            }

        }

        return data;
    }

}


