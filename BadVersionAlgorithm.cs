namespace BinarySearch
{
    public class BadVersionAlgorithm
    {
        public int FirstBadVersion(int n)
        {
            int low = 0, high = n, mid;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (isBadVersion(mid))
                {
                    if (isBadVersion(mid - 1) == false)
                    {
                        return mid;
                    }
                    else
                    {
                        high = mid;
                    }
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private bool isBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}
