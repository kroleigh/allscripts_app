namespace nothinbutdotnetstore
{
    public interface ICalculate
    {
        int add(int first, int second);
    }

    public class Calculator : ICalculate
    {
        public int add(int first, int second)
        {
          if (first < 0 || second < 0)
            throw new System.ArgumentOutOfRangeException("inputs need to be positive.");
            return first + second;
        }
    }
}