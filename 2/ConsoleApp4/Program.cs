using System;
class Program
{
    static int first(int[] nums)
    {
        int mCount = 0;
        int cCount = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                cCount++;
                mCount = Math.Max(mCount, cCount);
            }
            else
            {
                cCount = 0;
            }
        }
        return mCount;
    }
    static int second1(int[] nums)
    {
        int count = 0;

        foreach (int num in nums)
        {
            int digitsCount = second2(num);
            if (digitsCount % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    static int second2(int num)
    {
        int count = 0;

        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
    static int[] third(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        int left = 0;
        int right = n - 1;
        int index = n - 1;

        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];

            if (leftSquare > rightSquare)
            {
                result[index] = leftSquare;
                left++;
            }
            else
            {
                result[index] = rightSquare;
                right--;
            }

            index--;
        }
        return result;
    }
    static void fourth(int[] arr)
    {
        int zeroes = 0;
        int length = arr.Length - 1;

        for (int i = 0; i <= length - zeroes; i++)
        {
            if (arr[i] == 0)
            {
                if (i == length - zeroes)
                {
                    arr[length] = 0;
                    length--;
                    break;
                }
                zeroes++;
            }
        }

        int last = length - zeroes;

        for (int i = last; i >= 0; i--)
        {
            if (arr[i] == 0)
            {
                arr[i + zeroes] = 0;
                zeroes--;
                arr[i + zeroes] = 0;
            }
            else
            {
                arr[i + zeroes] = arr[i];
            }
        }
    }
    static void fifth(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
    static int sixth(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int index = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
    static void Main()
    {
        Console.WriteLine("1");

        int[] nums1 = { 1, 1, 1, 1, 1, 1 };
        Console.WriteLine("\nInput: nums1");
        Console.WriteLine("Output: " + first(nums1));
        int[] nums11 = { 1, 0, 1, 1, 0, 1 };
        Console.WriteLine("\nInput: nums11");
        Console.WriteLine("Output: " + first(nums11));

        Console.WriteLine("\n2\n");

        int[] nums2 = { 12, 345, 2, 6, 7896 };
        Console.WriteLine("Input: nums2");
        Console.WriteLine("Output: " + second1(nums2));
        int[] nums22 = { 555, 901, 482, 1771 };
        Console.WriteLine("\nInput: nums22");
        Console.WriteLine("Output: " + second1(nums22));

        Console.WriteLine("\n3\n");

        int[] nums3 = { -4, -1, 0, 3, 10 };
        int[] result3 = third(nums3);
        Console.WriteLine("Input: nums3 = [-4, -1, 0, 3, 10]");
        Console.Write("Output: [");
        foreach (int num in result3)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");

        int[] nums33 = { -7, -3, 2, 3, 11 };
        int[] result33 = third(nums33);
        Console.WriteLine("\nInput: nums33 = [-7, -3, 2, 3, 11]");
        Console.Write("Output: [");
        foreach (int num in result33)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");

        Console.WriteLine("\n4\n");

        int[] arr4 = { 1, 0, 2, 3, 0, 4, 5, 0 };
        Console.WriteLine("Input: arr4 = [1, 0, 2, 3, 0, 4, 5, 0]");
        fourth(arr4);
        Console.Write("Output: [");
        foreach (int num in arr4)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");

        int[] arr44 = { 1, 2, 3 };
        Console.WriteLine("\nInput: arr44 = [1, 2, 3]");
        fourth(arr44);
        Console.Write("Output: [");
        foreach (int num in arr44)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");

        Console.WriteLine("\n5\n");

        int[] nums5_1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums5_11 = { 2, 5, 6 };
        int m5_1 = 3;
        int n5_11 = 3;

        Console.WriteLine("Input: nums5_1 = [1, 2, 3, 0, 0, 0], m5_1 = 3, nums5_11 = [2, 5, 6], n5_11 = 3");
        fifth(nums5_1, m5_1, nums5_11, n5_11);

        Console.Write("Output: [");
        for (int i = 0; i < nums5_1.Length; i++)
        {
            Console.Write(nums5_1[i]);
            if (i < nums5_1.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");

        int[] nums5_2 = { 1};
        int[] nums5_22 = {};
        int m5_2 = 1;
        int n5_22 = 0;

        Console.WriteLine("Input: nums5_2 = [1], m5_2 = 1, nums5_22 = [], n5_22 = 0");
        fifth(nums5_2, m5_2, nums5_22, n5_22);

        Console.Write("Output: [");
        for (int i = 0; i < nums5_2.Length; i++)
        {
            Console.Write(nums5_2[i]);
            if (i < nums5_2.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");

        Console.WriteLine("\n6\n");

        int[] nums6_1 = { 1, 1, 2 };
        Console.WriteLine("Input: nums = [1, 1, 2]");
        int k6_1 = sixth(nums6_1);
        Console.WriteLine("Output: " + k6_1 + ", nums = [" + string.Join(", ", nums6_1) + "]");

        int[] nums6_2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine("\nInput: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]");
        int k6_2 = sixth(nums6_2);
        Console.WriteLine("Output: " + k6_2 + ", nums = [" + string.Join(", ", nums6_2) + "]");

    }
}
