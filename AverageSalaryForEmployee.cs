namespace Leetcode
{
    public class AverageSalaryForEmployee
    {
        public double Average(int[] salary)
        {
            Array.Sort(salary);
            double sum = 0;
            for (int i = 1; i < salary.Length - 1; i++)
            {
                sum += salary[i];
            }
            return (sum) / (salary.Length - 2);
        }
    }
}
